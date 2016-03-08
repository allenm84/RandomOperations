using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomOperations
{
  public class TextToBinary : Operation
  {
    private TextInput input;

    public TextToBinary()
    {
      input = new TextInput
      {
        Text = string.Empty,
      };
    }

    public override string DisplayName
    {
      get { return "Text to Binary"; }
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
      return new[]
      {
        string.Join(" ", input.Text
          .Select(Convert.ToInt32)
          .Select(i => Convert.ToString(i, 2).PadLeft(8, '0'))),
      };
    }
  }
}
