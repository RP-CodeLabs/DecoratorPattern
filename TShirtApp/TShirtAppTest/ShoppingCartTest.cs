using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TShirtAppTest
{
    [TestClass]
    public class ShoppingCartTest
    {
        [TestMethod]
        public void calculate_tshirt_price()
        {
            //var cost = new TshirtDesignCost();
            //ITshirtPrice tshirtPrice = new TshirtPrice(cost.DesignCost);
            //var shoppingCart = new ShoppingCart(tshirtPrice);
            //IDiscountCalculator discountCalculator = new DiscountProvider();
            //var price = shoppingCart.CalculatePrice(cost.DesignCost);
            //var discountedPrice = discountCalculator.GetMemberDiscount(price);
            //Assert.AreEqual(104, discountedPrice);
            var tshirtPrice = new TshirtPriceProvider();
            var discountProvider = new DiscountProvider();

            var total = tshirtPrice.TshirtPrice("1").CalculatePrice(100);
        }
    }
}
