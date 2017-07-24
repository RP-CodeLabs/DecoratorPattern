using Microsoft.VisualStudio.TestTools.UnitTesting;
using TShirtApp;

namespace TShirtAppTest
{
    [TestClass]
    public class DiscountCalculatorTest
    {
        [TestMethod]
        public void calculate_student_discount()
        {
            var discountCalculator = new DiscountProvider();
            var studentDiscount = discountCalculator.Discount("Student");
            Assert.AreEqual(typeof(StudentDiscount), studentDiscount.GetType());
        }

        [TestMethod]
        public void calculate_member_discount()
        {
            var discountCalculator = new DiscountProvider();
            var memeberDiscount = discountCalculator.Discount("Member");
            Assert.AreEqual(typeof(MemberDiscount), memeberDiscount.GetType());
        }

        [TestMethod]
        public void calculate_student_member_discount()
        {
            var discountCalculator = new DiscountProvider();
            var studentMemberDiscount = discountCalculator.Discount("StudentMember");
            Assert.AreEqual(typeof(StudentMemberDiscount), studentMemberDiscount.GetType());
        }
    }
}
