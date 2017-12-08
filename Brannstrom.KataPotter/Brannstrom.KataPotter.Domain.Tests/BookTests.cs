using FluentAssertions;
using NUnit.Framework;

namespace Brannstrom.KataPotter.Domain.Tests
{
    [TestFixture]
    public class BookTests
    {
        private Book _book;

        [SetUp]
        public void SetUp()
        {
            _book = new Book("id", "Title", 8);
        }

        [Test]
        public void Should_Have_Id()
        {
            _book.Id.Should().Be("id");
        }

        [Test]
        public void Should_Have_Title()
        {
            _book.Title.Should().Be("Title");
        }

        [Test]
        public void Should_Cost_8()
        {
            _book.Price.Should().Be(8);
        }
    }
}
