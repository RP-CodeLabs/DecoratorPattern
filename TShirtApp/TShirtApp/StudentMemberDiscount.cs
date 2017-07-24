namespace TShirtApp
{
    public class StudentMemberDiscount : IDiscount
    {
        public decimal GetDiscount(decimal total)
        {
            return total - (total * 0.3m);
        }
    }
}
