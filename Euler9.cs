//Problem 9 - Special Pythagorean triplet
//A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,

//a^2 + b^2 = c^2
//For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.

//There exists exactly one Pythagorean triplet for which a + b + c = 1000.
//Find the product abc.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Euler9
    {
        public static ulong euler_9()
        {
            Console.WriteLine();
            List<int[]> list = new List<int[]>();
            
            list = generate_triplets();
            int a = 0;
            int b = 0;
            int c = 0;
            int result = 0;
            foreach (var item in list)
            {
                if (is_pythag_triplet(item))
                {
                    a = item[0];
                    b = item[1];
                    c = item[2];
                }
            }
            result = (a * b * c);
            return Convert.ToUInt64(result);
        }

        private static List<int[]> generate_triplets()
        {
            int a;
            int[] tripArray;
            List<int[]> list = new List<int[]>();
            for (int c = 335; c < 997; c++)
            {
                for (int b = 2; b < 499; b++)
                {
                    a = 1000 - b - c;
                    tripArray = new int[3] { a, b, c };
                    if (a + b + c == 1000 && c > b && b > a)
                        list.Add(tripArray);
                }
            }
            return list;
        }

        private static void print_list(List<int[]> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine("a: {0}, b: {1}, c: {2}, sum: {3}"
                    , item[0], item[1], item[2],
                    (item[0] + item[1] + item[2]));
            }
            Console.WriteLine("list length: {0}", list.Count);
        }
        private static bool is_pythag_triplet(int[] tripArray)
        {
            if (Math.Pow(tripArray[0], 2) + (Math.Pow(tripArray[1], 2)) == Math.Pow(tripArray[2], 2))
                return true;
            else
                return false;
        }
    }
}
