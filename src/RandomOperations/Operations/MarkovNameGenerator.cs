using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomOperations.Properties;

namespace RandomOperations
{
  public class MarkovNameGenerator : Operation
  {
    static MarkovName female;
    static MarkovName male;
    static MarkovName last;

    static char[] newline = Environment.NewLine.ToCharArray();
    static char[] space = new char[] { ' ' };

    static MarkovNameGenerator()
    {
      female = new MarkovName(GetEntries(Resources.dist_female_first));
      male = new MarkovName(GetEntries(Resources.dist_male_first));
      last = new MarkovName(GetEntries(Resources.dist_all_last));
    }

    static IEnumerable<string> GetEntries(string text)
    {
      return text
        .Split(newline, StringSplitOptions.RemoveEmptyEntries)
        .Select(l => l.Trim())
        .Where(l => !string.IsNullOrWhiteSpace(l))
        .Select(l => l.Split(space, 2)[0]);
    }

    private enum Gender { Male, Female };
    private class Input
    {
      [DefaultValue(Gender.Male)]
      public Gender Gender { get; set; }
      [DefaultValue(false)]
      public bool IncludeLastName { get; set; }
    }

    private Input input;
    public MarkovNameGenerator()
    {
      input = new Input();
    }

    public override string DisplayName
    {
      get { return "Name Generator (Markov)"; }
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
      var result = new List<string>();

      var markovFirst = input.Gender == Gender.Male ? male : female;
      result.Add(markovFirst.NextName);

      if (input.IncludeLastName)
      {
        result.Add(last.NextName);
      }

      return result.ToArray();
    }
  }
}
