using System;

namespace Find_Maximum_Number_Day15
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing the maximum of three numbers");
            FindMaximumNum find = new FindMaximumNum();
            Console.WriteLine(find.MaximumFloatNumber(11.1f, 12.2f, 13.3f));
        }
    }
}
