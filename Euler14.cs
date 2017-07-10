//Problem 14 - Longest Collatz Sequence
//The following iterative sequence is defined for the set of positive integers:
//n → n/2 (n is even)
//n → 3n + 1 (n is odd)
//Using the rule above and starting with 13, we generate the following sequence:
//13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
//It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.
//Which starting number, under one million, produces the longest chain?
//NOTE: Once the chain starts the terms are allowed to go above one million.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Euler14
    {
        const ulong CEILING = 1000000;
        public static ulong euler_14()
        {
            ulong result = 0;
            ulong highest = 0;
            for (ulong i = 1; i < CEILING; i++)
            {
                if (gen_collatz(i) > highest)
                {
                    result = i;
                    highest = gen_collatz(i);
                }     
            }
            return (result);
        }

        public static ulong gen_collatz(ulong num)
        {
            ulong termcount = 0;
            while (num > 1)
            {
                if (num % 2 == 0)
                {
                    num = num / 2;
                }
                else
                {
                    num = (3 * num) + 1;
                }
                termcount++;
            }
            return termcount;
        }
    }
}
