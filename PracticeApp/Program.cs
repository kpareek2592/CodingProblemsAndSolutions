using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Transactions;

namespace PracticeApp
{
    class Program
    {
        // Driver Code 
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

        static void Main(string[] args)
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
