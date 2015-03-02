using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomOperations
{
  public abstract class Operation
  {
    public abstract string DisplayName { get; }
    public abstract bool NeedsInput { get; }
    public abstract object DataSource { get; }
    public abstract string[] GetResult();
  }
}
