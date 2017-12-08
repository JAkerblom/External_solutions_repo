using System;
using System.Collections.Generic;

namespace Brannstrom.KataPotter.Domain.Discounts
{
    public interface ICalculateDiscountForBooks
    {
        decimal Calculate(List<Book> books);
    }
}
