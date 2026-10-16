using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Problems
{
    public class FindDuplicate
    {
        public static void DuplicateElementsInArr(int[] arr)
        {
            Console.WriteLine();
            for(int i=0; i<=arr.Length-1; i++)
            {
                bool isDuplicate = false;
                for(int j=0; j<i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (isDuplicate)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
