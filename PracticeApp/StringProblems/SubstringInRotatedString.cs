using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeApp.StringProblems
{
    class SubstringInRotatedString
    {
        static bool isRotation(string a, string b)
        {
            string aa = a + a;
            return aa.Contains(b);
        }

        static void Main1(string[] args)
        {
            string b = "waterbottle";
            string a = "erbottlewat";
            var res = isRotation(a, b);

            Console.WriteLine(res);
        }
    }
}
