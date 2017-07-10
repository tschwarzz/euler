//Problem 6

//The sum of the squares of the first ten natural numbers is,
//1^2 + 2^2 + ... + 10^2 = 385

//The square of the sum of the first ten natural numbers is,
//(1 + 2 + ... + 10)^2 = 55^2 = 3025

//Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

//Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Euler6
    {
        public static ulong euler_6()
        {
            UInt64 diff = 100;
            ulong result = (squaresum(diff) - sumsquare(diff));
            return result;
        }
        private static UInt64  sumsquare(UInt64  num)
        {
            UInt64  result = 0;
            for (UInt64  i = 1; i <= num; i++)
            {
                result = result + Convert.ToUInt64(Math.Pow(i, 2));
            }
            return result;
        }

        private static UInt64 squaresum(UInt64 num)
        {
            UInt64 result = 0;
            UInt64 sum = 0;
            for (UInt64 i = 1; i <= num; i++)
            {
                sum = sum + i;
            }
            result = Convert.ToUInt64(Math.Pow(sum, 2));
            return result;
        }
    }

}
