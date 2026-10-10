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
    }
}
