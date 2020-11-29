using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeApp.Array
{
    public static class Deletion
    {
        public static (string response, int[] array) deleteElement(int[] array, int element)
        {
            (string response, int position) = validation(array, element);
            if (response != null)
                return (response, null);
            int size = array.Length;
            for (int i = position; i < size-1; i++)
            {
                array[i] = array[i + 1];
            }
            //array[size - 1] = null;
            return ("Element deleted", array);
        }

        public static (string response, int position) validation(int[] array, int element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (element == array[i])
                    return (null, i);
            }
            return ("Element not present", -1);
        }
    }
}
