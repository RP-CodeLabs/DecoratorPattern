namespace TShirtAppTest
{
    public class ShoppingCart
    {
        private readonly ITshirtPrice _tshirtPrice;

        public ShoppingCart(ITshirtPrice tshirtPrice)
        {
            _tshirtPrice = tshirtPrice;
        }

        public decimal CalculatePrice(decimal cost)
        {
            return _tshirtPrice.CalculatePrice(cost);
        }
    }
}