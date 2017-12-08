using System.Collections.Generic;
using Brannstrom.KataPotter.Domain.Discounts;
using FluentAssertions;
using NUnit.Framework;

namespace Brannstrom.KataPotter.Domain.Tests
{
    [TestFixture]
    public class ShoppingCartSolutionIntegrationTest
    {
        [Test]
        public void Should_Calculate_Correct_Price()
        {
            var shoppingCart = new ShoppingCart(new List<ICalculateDiscountForBooks>()
            {
                new CalculateDiscountForTwoBooks(),
                new CalculateDiscountForThreeBooks(),
                new CalculateDiscountForFourBooks(),
                new CalculateDiscountForFiveBooks()
            });

            shoppingCart.AddItem(new Book("id1", "Harry Potter and The Sorceror's Stone", 8));
            shoppingCart.AddItem(new Book("id1", "Harry Potter and The Sorceror's Stone", 8));
            shoppingCart.AddItem(new Book("id2", "Harry Potter and The Chamber Of Secrets", 8));
            shoppingCart.AddItem(new Book("id2", "Harry Potter and The Chamber Of Secrets", 8));
            shoppingCart.AddItem(new Book("id3", "Harry Potter and The Prisoner Of Azkaban", 8));
            shoppingCart.AddItem(new Book("id3", "Harry Potter and The Prisoner Of Azkaban", 8));
            shoppingCart.AddItem(new Book("id4", "Harry Potter and The Goblet Of Fire", 8));
            shoppingCart.AddItem(new Book("id5", "Harry Potter and The Order Of The Phoenix", 8));

            shoppingCart.CalculateTotal().Should().Be(51.2m);
        }
    }
}
