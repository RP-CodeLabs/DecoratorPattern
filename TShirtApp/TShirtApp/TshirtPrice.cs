namespace TShirtApp
{
    public class TshirtPrice : IPrice
    {
        private readonly ITshirtPrice _tshirtPrice;
        public TshirtPrice(ITshirtPrice tshirtPrice)
        {
            _tshirtPrice = tshirtPrice;
        }

        public decimal CalculatePrice(decimal price)
        {
            return _tshirtPrice.CalculatePrice(price);
        }
    }
}
