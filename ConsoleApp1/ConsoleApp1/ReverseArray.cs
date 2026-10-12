using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DSA_Problems
{
    public class ReverseArray
    {
        public static void ReverserArr(int[] arr) 
        {
            int left = 0;
            int right = arr.Length - 1;
            while(left < right)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;

                left++;
                right--;
            }
            Console.Write("Reversed Arry!: " +  string.Join(", ", arr));
        }
    }
}
