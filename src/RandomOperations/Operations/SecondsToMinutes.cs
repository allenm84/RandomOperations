using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomOperations
{
  public class SecondsToMinutes : Operation
  {
    private class Input
    {
      public int Seconds { get; set; }
    }

    private Input input;
    public SecondsToMinutes()
    {
      input = new Input();
    }

    public override string DisplayName
    {
      get { return "Convert Seconds"; }
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
      int seconds = input.Seconds;
      int minutes = seconds / 60;

      return new string[]
      {
        string.Format("{0} minute{1} {2} seconds", minutes, (minutes == 1 ? "" : "s"), seconds % 60),
      };
    }
  }
}
