﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeApp.Sorting
{
    public class SelectionSort
    {
        static void sort(int[] arr)
        {
            int n = arr.Length;

            // One by one move boundary of unsorted subarray 
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array 
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min_idx])
                        min_idx = j;

                // Swap the found minimum element with the first 
                // element 
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
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
