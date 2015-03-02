using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomOperations
{
  public class CharacterCount : Operation
  {
    private TextInput input;

    public CharacterCount()
    {
      input = new TextInput
      {
        Text = string.Empty,
      };
    }

    public override string DisplayName
    {
      get { return "Char Count"; }
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
        input.Text.Length.ToString(),
      };
    }
  }
}
