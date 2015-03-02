using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomOperations
{
  public class ConvertToFraction : Operation
  {
    private class Input
    {
      [DefaultValue(typeof(decimal), "0.25")]
      public decimal Value { get; set; }

      public Input()
      {
        Value = 0.25m;
      }
    }

    private Input input;
    public ConvertToFraction()
    {
      input = new Input();
    }

    public override string DisplayName
    {
      get { return "To Fraction"; }
    }

    public override bool NeedsInput
    {
      get { return true; }
    }

    public override object DataSource
    {
      get { return input; }
    }

    public static int[] toFraction(decimal x, decimal error = 0.000001m)
    {
      // http://stackoverflow.com/questions/5124743/algorithm-for-simplifying-decimal-to-fractions

      int n = (int)Math.Floor(x);
      x -= n;

      if (x < error) { return new[] { n, 1 }; }
      else if ((1 - error) < x) { return new[] { n + 1, 1 }; }

      // The lower fraction is 0/1
      int lower_n = 0;
      int lower_d = 1;

      // The upper fraction is 1/1
      int upper_n = 1;
      int upper_d = 1;

      while (true)
      {
        // The middle fraction is (lower_n + upper_n) / (lower_d + upper_d)
        int middle_n = lower_n + upper_n;
        int middle_d = lower_d + upper_d;
        // If x + error < middle
        if ((middle_d * (x + error)) < middle_n)
        {
          // middle is our new upper
          upper_n = middle_n;
          upper_d = middle_d;
        }
        // Else If middle < x - error
        else if (middle_n < ((x - error) * middle_d))
        {
          // middle is our new lower
          lower_n = middle_n;
          lower_d = middle_d;
        }
        // Else middle is our best fraction
        else
        {
          return new[] { n * middle_d + middle_n, middle_d };
        }
      }
    }

    public override string[] GetResult()
    {
      var arr = toFraction(input.Value);
      return new string[] { string.Format("{0}/{1}", arr[0], arr[1]) };
    }
  }
}
