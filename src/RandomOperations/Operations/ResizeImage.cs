using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RandomOperations
{
  public class ResizeImage : Operation
  {
    private ResizeImageInput input;

    public ResizeImage()
    {
      input = new ResizeImageInput
      {
        Size = new Size(1920, 1200),
        ShowDirectory = true,
      };
    }

    public override object DataSource
    {
      get { return input; }
    }

    public override string DisplayName
    {
      get { return "Resize Image"; }
    }

    public override bool NeedsInput
    {
      get { return true; }
    }

    public override string[] GetResult()
    {
      string message = "Resized Image";

      try
      {
        var uri = input.Uri;
        using (var client = new WebClient())
        {
          var data = client.DownloadData(uri);
          var stream = new MemoryStream(data);
          using (var image = Image.FromStream(stream))
          {
            var size = input.Size;

            using (var bitmap = new Bitmap(size.Width, size.Height))
            {
              using (var graphics = Graphics.FromImage(bitmap))
              {
                graphics.Clear(Color.Black);
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.DrawImage(image, 0, 0, size.Width, size.Height);
              }

              string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
              string name = string.Join("", uri.OriginalString.Split(Path.GetInvalidFileNameChars()));

              int salt = 0;
              string filepath = Path.Combine(docs, name);

              while (File.Exists(filepath))
              {
                filepath = Path.Combine(docs, string.Format("salt{0:0000}_{1}", salt++, name));
              }

              bitmap.Save(filepath, image.RawFormat);
              if (input.ShowDirectory)
              {
                Process.Start(docs);
              }
            }
          }
        }
      }
      catch (Exception ex)
      {
        message = ex.Message;
      }

      return new[] { message };
    }

    private class ResizeImageInput
    {
      public Size Size { get; set; }
      public Uri Uri { get; set; }
      public bool ShowDirectory { get; set; }
    }
  }
}
