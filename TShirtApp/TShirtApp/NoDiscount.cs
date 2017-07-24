namespace TShirtApp
{
    public class NoDiscount : IDiscount
    {
        public decimal GetDiscount(decimal total)
        {
            return total;
        }
    }
}