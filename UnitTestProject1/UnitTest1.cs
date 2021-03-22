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
            int actual = find.MaximumIntegerNumber(1, 2, 3);
            Assert.AreEqual(3, actual);
        }
        //TC1.2
        [TestMethod]
        public void Maximum_Value_Second_Parameter_Should_Return_Maximum_Value()
        {
            FindMaximumNum find = new FindMaximumNum();
            int actual = find.MaximumIntegerNumber(3, 2, 1);
            Assert.AreEqual(3, actual);
        }
        //TC1.3
        [TestMethod]
        public void Maximum_Value_Third_Parameter_Should_Return_Maximum_Value()
        {

            FindMaximumNum find = new FindMaximumNum();
            int actual = find.MaximumIntegerNumber(2, 1, 3);
            Assert.AreEqual(3, actual);
        }
    }
}
