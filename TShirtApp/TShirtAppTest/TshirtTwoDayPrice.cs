namespace TShirtAppTest
{
    public class TshirtTwoDayPrice : ITshirtPrice
    {
        public decimal CalculatePrice(decimal cost)
        {
            return cost + (cost * 0.2m);
        }
    }
}