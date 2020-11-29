using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeApp.Sorting
{
    public class BubbleSort
    {
        static void sort(int[] arr)
        {
            int n = arr.Length;

            // One by one move boundary of unsorted subarray 
            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n-1-i; j++)
                {
                    // compare the adjacent elements and find the minimum
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap the found minimum element with the first 
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }
        }

        // Prints the array 
        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        // Driver code  
        public static void Main1()
        {
            int[] arr = { 13, 55, 15, 9, 14, 25, 5, 33, 7, 2 };
            sort(arr);
            Console.WriteLine("Sorted array");
            printArray(arr);
        }
    }
}
