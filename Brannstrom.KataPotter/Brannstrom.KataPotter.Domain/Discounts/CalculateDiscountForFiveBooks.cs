namespace Brannstrom.KataPotter.Domain.Discounts
{
    public class CalculateDiscountForFiveBooks : CalculateDiscountForMultipleBooks
    {
        private static int AmountOfBooks => 5;
        private static decimal Discount => 0.25m;

        public CalculateDiscountForFiveBooks() : base(AmountOfBooks, Discount) {}
    }
}
