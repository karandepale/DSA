using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Problems
{
    public class SecondSmallest
    {
        public static void secondSmallestElement(int[]arr)
        {
            int lowest = int.MaxValue;
            int secondLowest = int.MaxValue;

            for(int i=0; i<=arr.Length-1; i++)
            {
                if (arr[i] < lowest)
                {
                    secondLowest = lowest;
                    lowest = arr[i];
                }
                else if (arr[i] < secondLowest)
                {
                    secondLowest = arr[i];
                }
            }
            Console.WriteLine($"Second Lowest Element is: {secondLowest}");

        }
    }
}
