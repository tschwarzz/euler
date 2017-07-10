//Problem 10 Summation of primes
//The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

//Find the sum of all the primes below two million.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Euler10
    {
        public static ulong euler_10()
        {
            const int HEIGHT = 2000000;
            ulong sum = 0;
            for (ulong i = 2; i < HEIGHT; i++)
            {
                if (isPrime (i))
                {
                    sum = sum + i;
                }  
            }
            return sum;
        }

        private static bool isPrime(UInt64 value)
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
