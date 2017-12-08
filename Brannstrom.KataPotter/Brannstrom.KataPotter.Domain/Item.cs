namespace Brannstrom.KataPotter.Domain
{
    public abstract class Item
    {
        public string Id { get; }

        protected Item(string id)
        {
            Id = id;
        }

        public override bool Equals(object obj)
        {
            return (obj is Item) && ((Item)obj).Id == Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
