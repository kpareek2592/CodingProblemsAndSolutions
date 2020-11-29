using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeApp.StringProblems
{
    public class DuplicateCharacters
    {
        static bool UniqueCharacters(string a)
        {
            int val;
            a = a.Replace(" ", string.Empty);
            bool[] char_set = new bool[256];
            for (int i = 0; i < a.Length; i++)
            {
                val = a[i];
                if (char_set[val])
                    return false;
                else
                    char_set[val] = true;
            }
            return true;
        }

        static void Main1(string[] args)
        {
            string a = "apple is";
            var res = UniqueCharacters(a);

            Console.WriteLine(res);
        }
    }
}
