//Problem 3
//The prime factors of 13195 are 5, 7, 13 and 29.

//What is the largest prime factor of the number 600,851,475,143 ?
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Euler3
    {
        public static void euler_3()
        {
            List<int> alist = new List<int>() { 1, 2, 3, 4, 5 };
            foreach (var item in alist)
            {
                Console.WriteLine("list element: " + item);
            }
            Console.WriteLine("product of list: {0}", ListProduct(alist));
            Console.ReadLine();
        }

        static List<int> PFactorsOf(int value)
        {
            List<int> factors = new List<int>();
            return factors;
        }
        static int ListProduct(List<int> list)
        {
            int product = 0;
            if (list.Count > 0)
            {
                product = 1;
                foreach (int i in list)
                {
                    product = product * i;
                }

            }
            return product;
        }

        private static bool isPrime(int value)
        {
            int root = Convert.ToInt32(Math.Sqrt(value));
            for (int i = 1; i < root; i++)
            {
                if (value % i == 0) return false;
            }
            return true;
        }
    }
}
