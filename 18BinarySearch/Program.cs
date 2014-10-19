using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _18BinarySearch
{
    class Program
    {
        static int BinarySearch(int[] array, int value)
        {
            // Returns the index in array where value is.
            // If value is not in array then -1 is returned
            int low = 0, high = array.Length - 1, midpoint = 0;
            while (low <= high)
            {
                midpoint = low + (high - low) / 2;
                //check to see if value is equal to item in array
                if (value == array[midpoint])
                {
                    return midpoint;
                }
                else if (value < array[midpoint])
                {
                    high = midpoint - 1;
                }
                else {
                    low = midpoint + 1;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] list = { 1, 2, 3, 4, 5, 6, 10 };
            Console.WriteLine(BinarySearch(list,10));
            Console.ReadLine();
        }
    }
}
