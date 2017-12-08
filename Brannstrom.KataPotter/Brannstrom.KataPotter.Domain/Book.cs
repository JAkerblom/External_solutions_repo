namespace Brannstrom.KataPotter.Domain
{
    public class Book : Item
    {
        public string Title { get; }
        public decimal Price { get; }

        public Book(string id, string title, decimal price) : base(id)
        {
            Title = title;
            Price = price;
        }
    }
}
