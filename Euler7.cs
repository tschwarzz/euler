//Problem 7
//By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

//What is the 10 001st prime number?

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Euler7
    {
        public static ulong euler_7()
        {
            int pcount = 0;
            ulong num = 2;
            int nth = 10001;
            ulong highest = num;
            while (pcount < nth)
            {
                if (isPrime(num))
                {
                    pcount++;
                    highest = num;
                    num++;
                }
                else num++;
            }
            return (highest);
        }
        private static bool isPrime(UInt64  value)
        {
            ulong root = Convert.ToUInt64(Math.Sqrt(value));
            for (ulong i = 2; i <= root; i++)
            {
                if (value % i == 0)
                    return false;
            }
            return true;
        }
    }
}
