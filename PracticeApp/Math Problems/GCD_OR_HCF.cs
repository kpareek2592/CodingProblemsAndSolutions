using System;

namespace PracticeApp.Math_Problems
{
    class GCD_OR_HCF
    {
        static int GCD(int a, int b)
        {
            int mod = a % b;
            if (mod == 0)
                return b;
            else
            {
                return GCD(b, mod);
            }
        }

        static void Main1(string[] args)
        {
            int a = 36;
            int b = 60;
            int res;

            if (a > b)
                res = GCD(a, b);
            else
                res = GCD(b, a);

            Console.WriteLine(res);
        }
    }
}
