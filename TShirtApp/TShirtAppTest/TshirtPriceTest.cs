using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TShirtAppTest
{
    [TestClass]
    public class TshirtPriceTest
    {
        [TestMethod]
        public void calculate_tshirt_price_one_day()
        {
            var designCost = new TshirtDesignCost();
            var tShirtPrice = new TshirtPrice(designCost.DesignCost);
            var oneDayPrice = tShirtPrice.CalculateOneDayPrice();
            Assert.AreEqual(130,oneDayPrice);
        }

        [TestMethod]
        public void calculate_tshirt_price_two_days()
        {
            var designCost = new TshirtDesignCost();
            var tShirtPrice = new TshirtPrice(designCost.DesignCost);
            var oneDayPrice = tShirtPrice.CalculateTwoDayPrice();
            Assert.AreEqual(120, oneDayPrice);
        }

        [TestMethod]
        public void calculate_tshirt_price_three_days()
        {
            var designCost = new TshirtDesignCost();
            var tShirtPrice = new TshirtPrice(designCost.DesignCost);
            var oneDayPrice = tShirtPrice.CalculateThreeDayPrice();
            Assert.AreEqual(110, oneDayPrice);
        }
    }
}
