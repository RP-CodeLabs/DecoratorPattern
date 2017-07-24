using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TShirtAppTest
{
    [TestClass]
    public class TshirtDesignCostTest
    {
        [TestMethod]
        public void Calculate_Tshirt_Design_Price()
        {
            var tShirtPrice = new TshirtDesignCost();
            var total = tShirtPrice.DesignCost;
            Assert.AreEqual(100, total);
        }
    }

    public class TshirtDesignCost
    {
        public decimal DesignCost { get; } = 100;
    }
}
