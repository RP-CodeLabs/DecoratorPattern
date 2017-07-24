namespace TShirtAppTest
{
    public class MemberDiscount : IDiscount
    {
        public decimal GetDiscount(decimal total)
        {
            return total - (total * 0.2m);
        }
    }
}