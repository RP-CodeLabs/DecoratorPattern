namespace TShirtAppTest
{
    public class StudentDiscount : IDiscount
    {
        public decimal GetDiscount(decimal total)
        {
            return total - (total * 0.1m);
        }
    }
}