using Microsoft.VisualStudio.TestTools.UnitTesting;
using Find_Maximum_Number_Day15;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //TC1.1
        public void Passing_Integer_Array_Should_Return_Maximum_Value()
        {
            int[] intArray = { 1, 2, 3 };
            FindMax<int> first = new FindMax<int>(intArray);
            int actual = first.FindMaxValue();
            Assert.AreEqual(30, actual);
        }
        //TC1.2
        [TestMethod]
        public void Passing_Float_Array_Should_Return_Maximum_Value()
        {
            float[] floatArray = { 11.1f, 12.2f, 13.3f };
            FindMax<float> secod = new FindMax<float>(floatArray);
            float actual = secod.FindMaxValue();
            Assert.AreEqual(30.5f, actual);
        }
        //TC1.3
        [TestMethod]
        public void Passing_String_Array_Should_Return_Maximum_Value()
        {

            string[] strArray = { "apple", "banana", "peach" };
            FindMax<string> third = new FindMax<string>(strArray);
            string actual = third.FindMaxValue();
            Assert.AreEqual(3, actual);
        }
    }
}
