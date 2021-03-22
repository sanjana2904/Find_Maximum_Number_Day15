using System;
using System.Collections.Generic;
using System.Text;

namespace Find_Maximum_Number_Day15
{
    public class FindMax<T> where T : IComparable
    {
       // public static <T extends Comparable<T>> T maximum()

        public T[] array;
        public FindMax(T[] array)
        {
            this.array = array;
        }

        public T[] Sort()
        {
            Array.Sort(array);
            return array;
        }
        public T FindMaxValue()
        {
            T[] sorted = this.Sort();
           // return;
            return sorted[sorted.Length - 1];
        }
    }
}