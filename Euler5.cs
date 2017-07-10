//Problem 5
//2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

//What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Euler5
    {
        public static ulong euler_5()
        {
            ulong num = 2;
            while (true)
            {
                if (clean20(num))
                    break;
                else
                {
                    num = num + 2;
                }
            }
            return (num);
        }

        private static bool clean20(ulong num)
        {
            for (ulong i = 2; i <= 20; i++)
            {
                if (num % i != 0)
                    return false;
            }
            return true;
        }
    }
}
