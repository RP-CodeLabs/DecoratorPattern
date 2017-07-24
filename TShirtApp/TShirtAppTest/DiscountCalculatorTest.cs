using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TShirtAppTest
{
    [TestClass]
    public class DiscountCalculatorTest
    {
        [TestMethod]
        public void calculate_student_discount()
        {
            var discountCalculator = new DiscountProvider();
            var discount = discountCalculator.StudentDiscount.GetStudentDiscount(100);
            Assert.AreEqual(90, discount);
        }

        [TestMethod]
        public void calculate_member_discount()
        {
            var discountCalculator = new DiscountProvider();
            var discount = discountCalculator.MemberDiscount.GetMemberDiscount(100);
            Assert.AreEqual(80, discount);
        }

        [TestMethod]
        public void calculate_student_member_discount()
        {
            var discountCalculator = new DiscountProvider();
            var discount = discountCalculator.StudentDiscount.GetStudentMemberDiscount(100);
            Assert.AreEqual(70, discount);
        }
    }
}
