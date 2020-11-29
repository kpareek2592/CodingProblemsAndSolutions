using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeApp.StringProblems
{
    // Check if one string is permutation of another string
    class Anagram
    {
        static bool IsAnagram(string a, string b)
        {
            var dict = new Dictionary<char, int>();
            if (a.Length != b.Length)
                return false;
            foreach (var ele in a)
            {
                if (!dict.ContainsKey(ele))
                {
                    dict[ele] = 1;
                }
                else
                    dict[ele]++;
            }

            foreach (var ele in b)
            {
                if (!dict.ContainsKey(ele))
                {
                    dict[ele] = 1;
                }
                else
                    dict[ele]++;
            }

            foreach (var ele in dict.Values)
            {
                if (ele % 2 != 0)
                    return false;
            }

            return true;
        }

        static void Main1(string[] args)
        {
            string a = "appla";
            string b = "pplae";
            var res = IsAnagram(a, b);

            Console.WriteLine(res);
        }
    }
}
