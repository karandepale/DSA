using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Problems
{
    public class AllzeroToEnd
    {
        public static void AllzeroEnd(int[] arr)
        {
            Console.WriteLine("Move all zeros to end");
            int j = 0;
            for(int i=0; i<=arr.Length-1; i++)
            {
                if (arr[i] != 0)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                    j++;
                }
            }
            Console.Write(String.Join(" ", arr));
        }
        
        public static void AllzeroStart(int[] arr)
        {
            Console.WriteLine();
            Console.WriteLine("All zero start");
            int j = arr.Length-1;
            for(int i=arr.Length-1; i>=0; i--)
            {
                if(arr[i] != 0)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    j--;
                }
            }
            Console.Write(string.Join(" ", arr));
        }
    }
}
