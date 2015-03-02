using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomOperations
{
  public class ShuffleCharacters : Operation
  {
    private TextInput input;
    private Random random = new Random();

    public ShuffleCharacters()
    {
      input = new TextInput
      {
        Text = string.Empty,
      };
    }

    public override string DisplayName
    {
      get { return "Shuffle Characters"; }
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
        new string(input
          .Text
          .OrderBy(c => random.Next())
          .ToArray()),
      };
    }
  }
}
