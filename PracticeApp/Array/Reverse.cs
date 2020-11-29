using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeApp.Array
{
    public static class Reverse
    {
        public static int[] reverse(int[] array)
        {
            int size = array.Length;
            int halfSize = size / 2;
            int temp;
            for (int i = 0; i < halfSize; i++)
            {
                temp = array[i];
                array[i] = array[size - 1 - i];
                array[size - 1 - i] = temp;
            }

            return array;
        }
    }
}
