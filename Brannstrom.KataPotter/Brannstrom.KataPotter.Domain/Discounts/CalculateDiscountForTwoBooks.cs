namespace Brannstrom.KataPotter.Domain.Discounts
{
    public class CalculateDiscountForTwoBooks : CalculateDiscountForMultipleBooks
    {
        private static int AmountOfBooks => 2;
        private static decimal Discount => 0.05m;

        public CalculateDiscountForTwoBooks() : base(AmountOfBooks, Discount){}
    }
}
