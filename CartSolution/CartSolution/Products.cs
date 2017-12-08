using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartSolution
{
  #region Products

  [Serializable]
  public abstract class Product : EntityBase
  {
    protected internal Product()
    {
    }

    public Product(string name, decimal price)
    {
      Name = name;
      Price = price;
    }

    public virtual string Name { get; set; }
    public virtual decimal Price { get; set; }
  }

  // generic product used in most situations for simple products 
  [Serializable]
  public class GenericProduct : Product
  {
    protected internal GenericProduct()
    {
    }

    public GenericProduct(String name, Decimal price) : base(name, price)
    {
    }
  }

  // custom product with additional properties and methods
  [Serializable]
  public class EventItem : Product
  {
    protected internal EventItem()
    {
    }

    public EventItem(string name, decimal price) : base(name, price)
    {
    }
  }

  #endregion
}
