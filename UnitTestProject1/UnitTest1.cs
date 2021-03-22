using Microsoft.VisualStudio.TestTools.UnitTesting;
using Find_Maximum_Number_Day15;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void Maximum_Value_First_Parameter_Should_Return_Maximum_Value()
        {
            FindMaximumNum find = new FindMaximumNum();
            string max = find.MaximumStringNumber("apple", "banana", "peach");
            Assert.AreEqual("peach", max);
        }
        //TC1.2
        [TestMethod]
        public void Maximum_Value_Second_Parameter_Should_Return_Maximum_Value()
        {
            FindMaximumNum find = new FindMaximumNum();
            string max = find.MaximumStringNumber("apple", "banana", "peach");
            Assert.AreEqual("peach", max);
        }
        //TC1.3
        [TestMethod]
        public void Maximum_Value_Third_Parameter_Should_Return_Maximum_Value()
        {

            FindMaximumNum find = new FindMaximumNum();
            string max = find.MaximumStringNumber("apple", "banana", "peach");
            Assert.AreEqual("peach", max);
        }
    }
}
