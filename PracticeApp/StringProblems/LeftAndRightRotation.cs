using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeApp.StringProblems
{
    class LeftAndRightRotation
    {
        static String leftrotate(String str, int d)
        {
            String ans = str.Substring(d, str.Length - d) + str.Substring(0, d);
            return ans;
        }

        // function that rotates s towards right by d 
        static String rightrotate(String str, int d)
        {
            return leftrotate(str, str.Length - d);
        }

        // Driver code
        public static void Main1(String[] args)
        {
            String str1 = "GeeksforGeeks";
            Console.WriteLine(leftrotate(str1, 2));

            String str2 = "GeeksforGeeks";
            Console.WriteLine(rightrotate(str2, 2));
        }
    }
}
