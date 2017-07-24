namespace TShirtApp
{
    public class TshirtThreeDayPriITshirtPricece : ITshirtPrice
    {
        public decimal CalculatePrice(decimal cost)
        {
            return cost + (cost * 0.1m);
        }
    }
}