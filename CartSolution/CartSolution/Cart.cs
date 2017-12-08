using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartSolution
{
  #region Cart

  [Serializable]
  public class Cart : OrderBase
  {
    protected internal Cart()
    {
    }

    public Cart(Member member)
        : base(member)
    {
    }
  }

  #endregion
}
