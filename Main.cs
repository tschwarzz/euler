using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Euler
    {
        static void Main()
        {
            //Euler1.euler_1();
            //Euler2.euler_2();
            //Euler3.euler_3();
            //Euler4.euler_4();

            List<int> primes = new List<int>();
            for (int i = 2; i < 1000; i++)
            {
                if (isPrime(i))
                {
                    primes.Add(i);
                }
            }
            Console.WriteLine("done");
            Console.ReadLine();
            for (int i = 0; i < primes.Count; i++)
			{
                Console .Write("{0:000} ", primes[i]);
                if ((i + 1) % 10 == 0)
	{
                    Console .WriteLine ();
	}
			}
            Console.WriteLine("done");
            Console.ReadLine();
        }

        private static bool isPrime(int value)
        {
            int root = Convert.ToInt32(Math.Sqrt(value));
            for (int i = 2; i <= root; i++)
            {
                if (value % i == 0)
                    return false;
            }
            return true;
        }
    }
}
