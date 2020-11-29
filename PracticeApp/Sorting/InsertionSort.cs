using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeApp.Sorting
{
    public class InsertionSort
    {
        void sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1], 
                // that are greater than key, 
                // to one position ahead of 
                // their current position 
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }

        // A utility function to print 
        // array of size n 
        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");

            Console.Write("\n");
        }

        // Driver Code 
        public static void Main1()
        {
            int[] arr = { 13, 55, 15, 9, 14, 25, 5, 33, 7, 2 };
            InsertionSort ob = new InsertionSort();
            ob.sort(arr);
            printArray(arr);
        }
    }
}
