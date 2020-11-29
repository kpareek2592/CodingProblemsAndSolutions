using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeApp.StringProblems
{
    class Anagram2
    {
        static bool IsAnagram(string a, string b)
        {
            var a1 = a.ToCharArray();
            var b1 = b.ToCharArray();

            System.Array.Sort(a1);
            System.Array.Sort(b1);

            a = string.Join("", a1);
            b = string.Join("", b1);

            if (a != b)
                return false;

            return true;
        }

        static void Main2(string[] args)
        {
            string a = "appla";
            string b = "pplae";
            var res = IsAnagram(a, b);

            Console.WriteLine(res);
        }
    }
}
