using System.Collections.Generic;
using Brannstrom.KataPotter.Domain.Discounts;
using FakeItEasy;
using FluentAssertions;
using NUnit.Framework;

namespace Brannstrom.KataPotter.Domain.Tests
{
    [TestFixture]
    public class ShoppingCartTests
    {
        private ShoppingCart _shoppingCart;
        private ICalculateDiscountForBooks _fakeDiscount;

        [SetUp]
        public void SetUp()
        {
            _fakeDiscount = A.Fake<ICalculateDiscountForBooks>();
            _shoppingCart = new ShoppingCart(new List<ICalculateDiscountForBooks>() { _fakeDiscount });
        }

        [Test]
        public void Should_Be_Able_To_Add_Item()
        {
            _shoppingCart.AddItem(new Book("id1", "Name", 8));

            _shoppingCart.Items.Count.Should().Be(1);
        }

        [Test]
        public void Should_Be_Able_To_Add_The_Same_Item_Twice()
        {
            var item = new Book("id1", "Name", 8);

            _shoppingCart.AddItem(item);
            _shoppingCart.AddItem(item);

            _shoppingCart.Items.Count.Should().Be(2);
        }

        [Test]
        public void Should_Calculate_Total_Price_For_One_Item()
        {
            _shoppingCart.AddItem(new Book("id1", "Name", 100));

            _shoppingCart.CalculateTotal().Should().Be(100);
        }

        [Test]
        public void Should_Calculate_Price_With_Discount()
        {
            A.CallTo(() => _fakeDiscount.Calculate(A<List<Book>>.Ignored)).Returns(10);

            _shoppingCart.AddItem(new Book("id1", "Name", 100));

            _shoppingCart.CalculateTotal().Should().Be(90);
        }
    }
}
