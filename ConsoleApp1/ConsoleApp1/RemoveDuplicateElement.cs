using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Problems
{
    public class RemoveDuplicateElement
    {
        public static void RemoveDuplicateItem(int[] arr)
        {
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
                if(isDuplicate == false)
                {
                    Console.Write($"{arr[i] + " "}");
                }
            }
        }

        public static void printDuplicate(int[] arr)
        {
            Console.WriteLine("PrintDuplicate");
            for (int i=0; i<=arr.Length-1; i++)
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
                if(isDuplicate)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }


    }
}
