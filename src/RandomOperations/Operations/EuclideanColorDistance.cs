using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomOperations
{
  public class EuclideanColorDistance : Operation
  {
    private class Input
    {
      public Color Color1 { get; set; }
      public Color Color2 { get; set; }
    }

    private Input input;
    public EuclideanColorDistance()
    {
      input = new Input
      {
        Color1 = Color.Blue,
        Color2 = Color.Red,
      };
    }

    private double Distance(Color x, Color y)
    {
      double r = x.R - y.R;
      double g = x.G - y.G;
      double b = x.B - y.B;
      return Math.Sqrt((r * r) + (g * g) + (b * b));
    }

    public override string DisplayName
    {
      get { return "Euclidean Color Distance"; }
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
      return new string[] 
      { 
        Distance(input.Color1, input.Color2).ToString() 
      };
    }
  }
}
