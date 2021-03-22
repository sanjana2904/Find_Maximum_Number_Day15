using System;

namespace Find_Maximum_Number_Day15
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing the maximum of three numbers");
            FindMaximumNum find = new FindMaximumNum();
            Console.WriteLine(find.MaximumIntegerNumber(1, 2, 3));
        }
    }
}
