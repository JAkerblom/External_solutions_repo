using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartSolution
{
  #region Member

  [Serializable]
  public class Member : EntityBase
  {
    protected internal Member() { }

    public Member(string name)
    {
      Name = name;
    }

    public virtual string Name { get; set; }
  }

  #endregion
}
