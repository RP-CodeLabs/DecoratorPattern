using Microsoft.VisualStudio.TestTools.UnitTesting;
using TShirtApp;

namespace TShirtAppTest
{
    [TestClass]
    public class TshirtPriceTest
    {
        private TshirtPriceProvider _tshirtPriceProvider;
        [TestInitialize]
        public void Setup()
        {
            _tshirtPriceProvider = new TshirtPriceProvider();
        }

        [TestMethod]
        public void calculate_tshirt_price_one_day()
        {
            var tShirtPrice = new TshirtPrice(_tshirtPriceProvider.TshirtPrice("1"));
            var oneDayPrice = tShirtPrice.CalculatePrice(100);
            Assert.AreEqual(130,oneDayPrice);
        }

        [TestMethod]
        public void calculate_tshirt_price_two_days()
        {
            var tShirtPrice = new TshirtPrice(_tshirtPriceProvider.TshirtPrice("2"));
            var oneDayPrice = tShirtPrice.CalculatePrice(100);
            Assert.AreEqual(120, oneDayPrice);
        }

        [TestMethod]
        public void calculate_tshirt_price_three_days()
        {
            var tShirtPrice = new TshirtPrice(_tshirtPriceProvider.TshirtPrice("3"));
            var oneDayPrice = tShirtPrice.CalculatePrice(100);
            Assert.AreEqual(110, oneDayPrice);
        }
    }
}
