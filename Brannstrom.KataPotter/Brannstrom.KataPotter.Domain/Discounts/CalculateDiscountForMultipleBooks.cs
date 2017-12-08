using System;
using System.Collections.Generic;
using System.Linq;

namespace Brannstrom.KataPotter.Domain.Discounts
{
    public abstract class CalculateDiscountForMultipleBooks : ICalculateDiscountForBooks
    {
        private int AmountOfBooks { get; }
        private decimal Discount { get; }

        protected CalculateDiscountForMultipleBooks(int amountOfBooks, decimal discount)
        {
            AmountOfBooks = amountOfBooks;
            Discount = discount;
        }

        public decimal Calculate(List<Book> books)
        {
            if (books.Distinct().Count() != AmountOfBooks) return 0;

            var currentPrice = books.Distinct().Sum(x => x.Price);
            return currentPrice * Discount;
        }
    }
}
