namespace Brannstrom.KataPotter.Domain.Discounts
{
    public class CalculateDiscountForThreeBooks : CalculateDiscountForMultipleBooks
    {
        private static int AmountOfBooks => 3;
        private static decimal Discount => 0.10m;

        public CalculateDiscountForThreeBooks() : base(AmountOfBooks, Discount){}
    }
}
