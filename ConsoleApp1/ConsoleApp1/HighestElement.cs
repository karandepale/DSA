using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DSA_Problems
{
    public class HighestElement
    {
        public static void HighestElementInArray(int[] arr)
        {
            int highestElement = arr[0];
            for(int i=1; i<=arr.Length-1; i++)
            {
                if (arr[i] > highestElement){
                highestElement = arr[i];
             }
               
            }
            Console.WriteLine($"Highest Element in the array: {highestElement}");
        }
    }
}
