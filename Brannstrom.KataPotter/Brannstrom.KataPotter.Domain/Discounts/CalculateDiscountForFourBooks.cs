namespace Brannstrom.KataPotter.Domain.Discounts
{
    public class CalculateDiscountForFourBooks : CalculateDiscountForMultipleBooks
    {
        private static int AmountOfBooks => 4;
        private static decimal Discount => 0.20m;

        public CalculateDiscountForFourBooks() : base(AmountOfBooks, Discount){}
    }
}
