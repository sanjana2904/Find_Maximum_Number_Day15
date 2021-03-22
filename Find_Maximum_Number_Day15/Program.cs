using System;

namespace Find_Maximum_Number_Day15
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing the maximum of three numbers");
            int[] intArray = { 1, 2, 3 };
            FindMaximumNum<int> find1 = new FindMaximumNum<int>(intArray);
            float[] floatArray = { 11.1f, 12.2f, 13.3f };
            FindMaximumNum<float> find2 = new FindMaximumNum<float>(floatArray);
            string[] stringArray = { "apple", "banana", "peach" };
            FindMaximumNum<string> find3 = new FindMaximumNum<string>(stringArray);
            find1.PrintMaxValue();
            find2.PrintMaxValue();
            find3.PrintMaxValue();
            //Console.WriteLine(find1.FindMaximumNum());
            //Console.WriteLine(find2.FindMaximumNum());
            //Console.WriteLine(find3.FindMaximumNum());

        }
    }
}



