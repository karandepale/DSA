using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Problems
{
    public class MissingElement
    {
        public static void findMissingElement(int[] arr, int n)
        {
            int expectedSum = n * (n + 1) / 2;
            int actualSum = 0;

            for(int i=0; i<=arr.Length-1; i++)
            {
                actualSum = actualSum + arr[i];
            }
            int missingNElement = expectedSum - actualSum;
            Console.WriteLine($"Missing Element: {missingNElement}");
        }
        
    }
}
