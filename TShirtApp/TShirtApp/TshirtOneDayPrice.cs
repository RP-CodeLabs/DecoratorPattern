namespace TShirtApp
{
    public class TshirtOneDayPrice : ITshirtPrice
    {
        public decimal CalculatePrice(decimal cost)
        {
            return cost + (cost * 0.3m);
        }
    }
}