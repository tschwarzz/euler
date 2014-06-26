using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Euler4
    {
        public static void euler_4()
        {
            int count = 0;
            int biggest = 0;
            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    if (isPalindrome(i * j))
                    {
                        count += 1;
                        if ((i * j) > biggest)
                            biggest = (i * j);
                        //Console.Write(" [{0} * {1}] ", i, j);
                        if (count % 5 == 0) ;
                            //Console.WriteLine();
                    }
                }
            }
            Console.WriteLine(biggest);
            Console.ReadLine();
        }
        private static bool isPalindrome(int num)
        //Checks if an integer is a palindrome
        {
            string myValue = Convert.ToString(num);
            string myValueR = reverseString(myValue);
            if (myValue == myValueR)
                return true;
            else return false;
        }

        private static string reverseString(string _string)
        //Takes a string and returns the reversed string
        {
            char[] charArray = _string.ToCharArray();
            Array.Reverse(charArray);
            string result = new string(charArray);
            return result;
        }
    }
}
