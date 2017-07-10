//Problem 20 - Factorial Digit Sum
//n! means n × (n − 1) × ... × 3 × 2 × 1
//For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
//and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.
//Find the sum of the digits in the number 100!
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Euler
{
    class Euler20
    {
        public static ulong euler_20()
        {
            BigInteger num = factorial(100);
            ulong result = Convert.ToUInt64((digitsum(Convert.ToString (num))));
            return result;
        }

        private static BigInteger factorial(int value)
        {
            BigInteger result = 1;
            for (int i = value; i > 1; i--)
            {
                result *= Convert.ToUInt64(i);
            }
            return result;
        }

        private static int digitsum(string value)
        {
            int result = 0;
            for (int i = 0; i < value.Length; i++)
            {
                result = result + Convert.ToInt32(value.Substring(i, 1));
            }
            return result;
        }
    }
}
