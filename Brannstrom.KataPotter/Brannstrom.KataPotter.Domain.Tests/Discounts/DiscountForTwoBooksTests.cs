using System.Collections.Generic;
using Brannstrom.KataPotter.Domain.Discounts;
using FluentAssertions;
using NUnit.Framework;

namespace Brannstrom.KataPotter.Domain.Tests.Discounts
{
    [TestFixture]
    public class DiscountForTwoBooksTests
    {
        [Test]
        public void Two_Books_Should_Get_5_Percent_Discount()
        {
            var books = new List<Book>()
            {
                new Book("id1", "Some Book", 100),
                new Book("id2", "Another Book", 100)
            };

            var discount = new CalculateDiscountForTwoBooks().Calculate(books);

            discount.Should().Be(10);
        }
    }
}
