using System;
using System.Collections.Generic;
using System.Linq;
using Brannstrom.KataPotter.Domain.Discounts;

namespace Brannstrom.KataPotter.Domain
{
    public class ShoppingCart
    {
        private readonly IEnumerable<ICalculateDiscountForBooks> _discounts;
        private List<List<Book>> _books { get; }

        public ShoppingCart(IEnumerable<ICalculateDiscountForBooks> discounts)
        {
            _discounts = discounts;
            _books = new List<List<Book>>();
        }

        public IReadOnlyList<Book> Items => _books.SelectMany(x => x).ToList();

        public void AddItem(Book book)
        {
            var group = FindGroupWithBestPrice(book);

            if (group != null)
                group.Add(book);
            else
                AddToNewGroup(book);
        }

        private List<Book> FindGroupWithBestPrice(Book book)
        {
            List<Book> groupWithBestPrice = null;
            var bestPrice = 0m;

            foreach (var collection in _books.Where(x => !x.Contains(book)))
            {
                var newPrice = CalculatePriceIfBookIsAddedToCollection(book, collection);
                if ((bestPrice == 0) || (newPrice < bestPrice))
                {
                    bestPrice = newPrice;
                    groupWithBestPrice = collection;
                }
            }

            return groupWithBestPrice;
        }

        private void AddToNewGroup(Book book) => _books.Add(new List<Book> { book });

        public decimal CalculateTotal() => _books.Sum(x => CalculatePriceForGroup(x));

        private decimal CalculatePriceForGroup(List<Book> listOfBooks)
        {
            var totalPrice = listOfBooks.Sum(x => x.Price);

            foreach (var discount in _discounts)
                totalPrice = totalPrice - discount.Calculate(listOfBooks);

            return totalPrice;
        }

        private decimal CalculatePriceIfBookIsAddedToCollection(Book book, List<Book> collection)
        {
            collection.Add(book);
            var newPrice = CalculateTotal();
            collection.Remove(book);

            return newPrice;
        }
    }
}
