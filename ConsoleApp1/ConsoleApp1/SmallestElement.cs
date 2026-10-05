using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Problems
{
    public class SmallestElement
    {
        public static void findSmallestElement(int[] arr)
        {
            int smallest = arr[0];
            for(int i=1; i<=arr.Length-1; i++)
            {
                if (arr[i] < smallest)
                {
                    smallest = arr[i];
                }
            }
            Console.WriteLine($"Smallest Element in the array: {smallest}");
        }
    }
}
