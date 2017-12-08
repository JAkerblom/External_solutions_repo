using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartSolution
{
  #region Discounts

  [Serializable]
  public abstract class Discount : EntityBase
  {
    protected internal Discount()
    {
    }

    public Discount(string name)
    {
      Name = name;
    }

    public virtual bool CanBeUsedInJuntionWithOtherDiscounts { get; set; }
    public virtual bool SupercedesOtherDiscounts { get; set; }
    public abstract OrderBase ApplyDiscount();
    public virtual OrderBase OrderBase { get; set; }
    public virtual string Name { get; private set; }
  }

  [Serializable]
  public class PercentageOffDiscount : Discount
  {
    protected internal PercentageOffDiscount()
    {
    }

    public PercentageOffDiscount(string name, decimal discountPercentage)
        : base(name)
    {
      DiscountPercentage = discountPercentage;
    }

    public override OrderBase ApplyDiscount()
    {
      // custom processing
      foreach (LineItem lineItem in OrderBase.LineItems)
      {
        lineItem.DiscountAmount = lineItem.Product.Price * DiscountPercentage;
        lineItem.AddDiscount(this);
      }
      return OrderBase;
    }

    public virtual decimal DiscountPercentage { get; set; }
  }

  [Serializable]
  public class BuyXGetYFree : Discount
  {
    protected internal BuyXGetYFree()
    {
    }

    public BuyXGetYFree(string name, IList<Product> applicableProducts, int x, int y)
        : base(name)
    {
      ApplicableProducts = applicableProducts;
      X = x;
      Y = y;
    }

    public override OrderBase ApplyDiscount()
    {
      // custom processing
      foreach (LineItem lineItem in OrderBase.LineItems)
      {
        if (ApplicableProducts.Contains(lineItem.Product) && lineItem.Quantity > X)
        {
          lineItem.DiscountAmount += ((lineItem.Quantity / X) * Y) * lineItem.Product.Price;
          lineItem.AddDiscount(this);
        }
      }
      return OrderBase;
    }

    public virtual IList<Product> ApplicableProducts { get; set; }
    public virtual int X { get; set; }
    public virtual int Y { get; set; }
  }

  [Serializable]
  public class SpendMoreThanXGetYDiscount : Discount
  {
    protected internal SpendMoreThanXGetYDiscount()
    {
    }

    public SpendMoreThanXGetYDiscount(string name, decimal threshold, decimal discountPercentage)
        : base(name)
    {
      Threshold = threshold;
      DiscountPercentage = discountPercentage;
    }

    public override OrderBase ApplyDiscount()
    {
      // if the total for the cart/order is more than x apply discount
      if (OrderBase.GrossTotal > Threshold)
      {
        // custom processing
        foreach (LineItem lineItem in OrderBase.LineItems)
        {
          lineItem.DiscountAmount += lineItem.Product.Price * DiscountPercentage;
          lineItem.AddDiscount(this);
        }
      }
      return OrderBase;
    }

    public virtual decimal Threshold { get; set; }
    public virtual decimal DiscountPercentage { get; set; }
  }

  #endregion
}
