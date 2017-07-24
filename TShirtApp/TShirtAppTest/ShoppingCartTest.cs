using Microsoft.VisualStudio.TestTools.UnitTesting;
using TShirtApp;

namespace TShirtAppTest
{
    [TestClass]
    public class ShoppingCartTest
    {
        private TshirtPriceProvider _tshirtPriceProvider;
        private DiscountProvider _discountProvider;

        [TestInitialize]
        public void Setup()
        {
            _tshirtPriceProvider = new TshirtPriceProvider();
            _discountProvider = new DiscountProvider();
        }

        [TestMethod]
        public void calculate_tshirt_price_one_day_delivery_with_no_discount()
        {
            var tshirtPrice = new TshirtPrice(_tshirtPriceProvider.TshirtPrice("1"));
            var discountCalculator = new DiscountCalculator(tshirtPrice, _discountProvider.Discount("None"));
            var price = discountCalculator.CalculatePrice(100);
            Assert.AreEqual(130, price);
        }

        [TestMethod]
        public void calculate_tshirt_price_one_day_delivery_with_student_discount()
        {
            var tshirtPrice = new TshirtPrice(_tshirtPriceProvider.TshirtPrice("1"));
            var discountCalculator = new DiscountCalculator(tshirtPrice, _discountProvider.Discount("Student"));
            var price = discountCalculator.CalculatePrice(100);
            Assert.AreEqual(117, price);
        }

        [TestMethod]
        public void calculate_tshirt_price_two_day_delivery_with_no_discount()
        {
            var tshirtPrice = new TshirtPrice(_tshirtPriceProvider.TshirtPrice("2"));
            var discountCalculator = new DiscountCalculator(tshirtPrice, _discountProvider.Discount("None"));
            var price = discountCalculator.CalculatePrice(100);
            Assert.AreEqual(120, price);
        }

        [TestMethod]
        public void calculate_tshirt_price_two_day_delivery_with_student_discount()
        {
            var tshirtPrice = new TshirtPrice(_tshirtPriceProvider.TshirtPrice("2"));
            var discountCalculator = new DiscountCalculator(tshirtPrice, _discountProvider.Discount("Student"));
            var price = discountCalculator.CalculatePrice(100);
            Assert.AreEqual(108, price);
        }

        [TestMethod]
        public void calculate_tshirt_price_two_day_delivery_with_member_discount()
        {
            var tshirtPrice = new TshirtPrice(_tshirtPriceProvider.TshirtPrice("2"));
            var discountCalculator = new DiscountCalculator(tshirtPrice, _discountProvider.Discount("Member"));
            var price = discountCalculator.CalculatePrice(100);
            Assert.AreEqual(96, price);
        }

        [TestMethod]
        public void calculate_tshirt_price_two_day_delivery_with_studentmember_discount()
        {
            var tshirtPrice = new TshirtPrice(_tshirtPriceProvider.TshirtPrice("2"));
            var discountCalculator = new DiscountCalculator(tshirtPrice, _discountProvider.Discount("StudentMember"));
            var price = discountCalculator.CalculatePrice(100);
            Assert.AreEqual(84, price);
        }
    }
}
