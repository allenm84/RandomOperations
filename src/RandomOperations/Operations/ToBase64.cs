using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RandomOperations
{
  public class ToBase64 : Operation
  {
    private TextInput input;

    public ToBase64()
    {
      input = new TextInput
      {
        Text = string.Empty,
      };
    }

    public override string DisplayName
    {
      get { return "Base64"; }
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
      byte[] bytes = Encoding.ASCII.GetBytes(input.Text);
      return new string[] { Convert.ToBase64String(bytes) };
    }
  }
}
