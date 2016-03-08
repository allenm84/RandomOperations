using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomOperations
{
  public class BinaryToText : Operation
  {
    private TextInput input;

    public BinaryToText()
    {
      input = new TextInput
      {
        Text = string.Empty,
      };
    }

    public override string DisplayName
    {
      get { return "Binary to Text"; }
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
        new string(input.Text.Split(' ')
          .Select(b => Convert.ToInt32(b, 2))
          .Select(Convert.ToChar)
          .ToArray()),
      };
    }
  }
}
