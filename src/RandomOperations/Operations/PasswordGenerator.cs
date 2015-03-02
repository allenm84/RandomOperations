using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomOperations
{
  public class PasswordGenerator : Operation
  {
    static char[] lower = "qwertyuiopasdfghjklzxcvbnm".ToCharArray();
    static char[] upper = "QWERTYUIOPASDFGHJKLZXCVBNM".ToCharArray();
    static char[] digits = "1234567890".ToCharArray();
    static char[] minus = "-".ToCharArray();
    static char[] underline = "_".ToCharArray();
    static char[] space = " ".ToCharArray();
    static char[] special = "!@#$%^&*+=:;\"\',.?/|\\`~".ToCharArray();
    static char[] brackets = "[]{}()<>".ToCharArray();
    static Random random = new Random();

    private class Input
    {
      [DefaultValue(24)]
      public int Length { get; set; }
      [DefaultValue(true)]
      public bool UpperCase { get; set; }
      [DefaultValue(true)]
      public bool LowerCase { get; set; }
      [DefaultValue(true)]
      public bool Digits { get; set; }
      [DefaultValue(false)]
      public bool Minus { get; set; }
      [DefaultValue(false)]
      public bool Underline { get; set; }
      [DefaultValue(false)]
      public bool Space { get; set; }
      [DefaultValue(false)]
      public bool Special { get; set; }
      [DefaultValue(false)]
      public bool Brackets { get; set; }
      [DefaultValue(5)]
      public int Count { get; set; }

      public Input()
      {
        Length = 24;
        UpperCase = true;
        LowerCase = true;
        Digits = true;
        Count = 5;
      }
    }

    private Input input;
    public PasswordGenerator()
    {
      input = new Input();
    }

    public override string DisplayName
    {
      get { return "Password Generator"; }
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
      var pool = new List<char>();
      if (input.UpperCase) { pool.AddRange(upper); }
      if (input.LowerCase) { pool.AddRange(lower); }
      if (input.Digits) { pool.AddRange(digits); }
      if (input.Minus) { pool.AddRange(minus); }
      if (input.Underline) { pool.AddRange(underline); }
      if (input.Space) { pool.AddRange(space); }
      if (input.Special) { pool.AddRange(special); }
      if (input.Brackets) { pool.AddRange(brackets); }

      var len = input.Length;
      var cnt = input.Count;
      var p = pool.Count;

      var pws = new List<string>(cnt * 2);
      var pw = new char[len];

      int c, i;
      for (c = 0; c < cnt; ++c)
      {
        for (i = 0; i < len; ++i)
        {
          pw[i] = pool[random.Next(p)];
        }
        pws.Add(new string(pw));
      }

      return pws.ToArray();
    }
  }
}
