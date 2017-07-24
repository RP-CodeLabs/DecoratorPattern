namespace TShirtApp
{
    public class DiscountCalculator : IPrice
    {
        private readonly IPrice _decorator;
        private readonly IDiscount _discount;

        public DiscountCalculator(IPrice tshirtPrice, IDiscount discount)
        {
            _decorator = tshirtPrice;
            _discount = discount;
        }

        public decimal CalculatePrice(decimal price)
        {
            return _decorator.CalculatePrice(_discount.GetDiscount(price));
        }
    }
}
