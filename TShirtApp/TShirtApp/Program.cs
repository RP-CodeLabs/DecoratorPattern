using static System.Console;
namespace TShirtApp
{
    class Program
    {
        static void Main()
        {
            var tshirtProvider = new TshirtPriceProvider();
            var discountProvider = new DiscountProvider();
            var tshirtPrice = new TshirtPrice(tshirtProvider.TshirtPrice("1"));
            var discountCalculator = new DiscountCalculator(tshirtPrice, discountProvider.Discount("None"));
            WriteLine(discountCalculator.CalculatePrice(100));
            ReadLine();
        }
    }
}
