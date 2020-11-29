using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net;
using System.Text;

namespace PracticeApp.Array
{
    public static class Insertion
    {
        // Method to insert element in an array
        public static (string response, int[] result) insertElement(int[] array, int element, int position)
        {
            int size = array.Length;
            var response = validation(size, element, position);
            if (response != null)
                return (response, null);
            int[] newArray = new int[size + 1];
            for (int i = 0; i < size+1; i++)
            {
                if (i < position - 1)
                    newArray[i] = array[i];
                else if (i == position - 1)
                    newArray[i] = element;
                else
                    newArray[i] = array[i - 1];
            }
            return ("Element inserted", newArray);
        }

        public static string validation(int size, int element, int position)
        {
            if (size + 1 < position)
                return "Invalid position";
            else
                return null;
        }
    }
}
