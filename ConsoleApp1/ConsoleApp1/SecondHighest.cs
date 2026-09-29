using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Problems
{
    public class SecondHighest
    {
        public static void secondHighestElement(int[] arr)
        {
            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            for(int i=0; i<arr.Length-1; i++)
            {
                if (arr[i] > largest)
                {
                    secondLargest = largest;
                    largest = arr[i];
                }
                else if (arr[i] > secondLargest)
                {
                    secondLargest = arr[i];
                }
            }
            Console.WriteLine($"Second Largest Element: {secondLargest}");
        }
    }
}
