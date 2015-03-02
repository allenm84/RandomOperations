using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomOperations
{
  public class SimpleNameGenerator : Operation
  {
    static char[] vowels = "aeiou".ToCharArray();
    static char[] consonants = "bcdefghjklmnpqrstvwxyz".ToCharArray();
    static char[][] pool = new[] { vowels, consonants };

    static Random random = new Random();

    public override string DisplayName
    {
      get { return "Name Generator (Simple)"; }
    }

    public override bool NeedsInput
    {
      get { return false; }
    }

    public override object DataSource
    {
      get { return null; }
    }

    public override string[] GetResult()
    {
      int len = random.Next(5, 9);
      var letters = new char[len];
      var p = random.Next() % 2;

      for (int i = 0; i < len; ++i, p = 1 - p)
      {
        var arr = pool[p];
        letters[i] = arr[random.Next(arr.Length)];
      }

      letters[0] = char.ToUpper(letters[0]);
      return new string[] { new string(letters) };
    }
  }
}
