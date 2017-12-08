using System.Collections.Generic;
using Brannstrom.KataPotter.Domain.Discounts;
using FluentAssertions;
using NUnit.Framework;

namespace Brannstrom.KataPotter.Domain.Tests.Discounts
{
    [TestFixture]
    public class DiscountForMultipleBooksTests
    {
        [Test]
        public void Should_Not_Add_Discount_For_Duplicates()
        {
            var books = new List<Book>()
            {
                new Book("id1", "Some Book", 100),
                new Book("id2", "Another Book", 100),
                new Book("id3", "Third book", 100),
                new Book("id3", "Third book", 100)
            };

            var discount = new CalculateDiscountForThreeBooks().Calculate(books);

            discount.Should().Be(30);
        }
    }
}
