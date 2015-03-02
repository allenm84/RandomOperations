using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RandomOperations
{
  public class CreateMD5Hash : Operation
  {
    private TextInput input;

    public CreateMD5Hash()
    {
      input = new TextInput
      {
        Text = string.Empty,
      };
    }

    public override string DisplayName
    {
      get { return "MD5 Hash"; }
    }

    public override bool NeedsInput
    {
      get { return true; }
    }

    public override object DataSource
    {
      get { return input; }
    }

    public override string[] GetResult()
    {
      using (var md5 = MD5.Create())
      {
        byte[] bytes = Encoding.ASCII.GetBytes(input.Text);
        byte[] hash = md5.ComputeHash(bytes);
        return new string[] { string.Join("", hash.Select(b => b.ToString("X2"))) };
      }
    }
  }
}
