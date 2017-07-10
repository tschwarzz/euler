using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Euler
{
    class Euler17
    {
        public static ulong euler_17()
        {
            StreamWriter file = new StreamWriter("Euler17.txt");
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(100, "onehundred");
            dict.Add(200, "twohundred");
            dict.Add(300, "threehundred");
            dict.Add(400, "fourhundred");
            dict.Add(500, "fivehundred");
            dict.Add(600, "sixhundred");
            dict.Add(700, "sevenhundred");
            dict.Add(800, "eighthundred");
            dict.Add(900, "ninehundred");
            dict.Add(1000, "onethousand");
            dict.Add(0, "and");
            dict.Add(1, "one");
            dict.Add(2, "two");
            dict.Add(3, "three");
            dict.Add(4, "four");
            dict.Add(5, "five");
            dict.Add(6, "six");
            dict.Add(7, "seven");
            dict.Add(8, "eight");
            dict.Add(9, "nine");
            dict.Add(11, "eleven");
            dict.Add(12, "twelve");
            dict.Add(13, "thirteen");
            dict.Add(14, "fourteen");
            dict.Add(15, "fifteen");
            dict.Add(16, "sixteen");
            dict.Add(17, "seventeen");
            dict.Add(18, "eighteen");
            dict.Add(19, "nineteen");
            dict.Add(20, "twenty");
            dict.Add(30, "thirty");
            dict.Add(40, "forty");
            dict.Add(50, "fifty");
            dict.Add(60, "sixty");
            dict.Add(70, "seventy");
            dict.Add(80, "eighty");
            dict.Add(90, "ninety");
            dict.Add(10, "ten");
            int result = 0;
            for (int i = 1; i <= 1000; i++)
            {
                result = result + (num_to_letters(i, dict)).Length;
                //file.WriteLine(num_to_letters(i, dict));
            }
            file.Close();
            return Convert.ToUInt64(result) ;
        }
        private static string num_to_letters(int num, Dictionary <int, string> dict)
        {
            string result = "";
            int rounded = num;
            if (num == 1000) return dict[1000];
            if (num % 100 == 0) return dict[num];
            if (num < 21) return dict[num];
            if (num > 100)
            {
                rounded = Convert.ToInt32(Math.Round((rounded - 50) / 100d, 0)) * 100;
                result = result + dict[rounded] +dict[0];
                rounded = Convert.ToInt32(num.ToString().Substring(1, 2));
                if (rounded < 21) result = result + dict[rounded];
                else
                {
                    num = rounded;
                    while (rounded >= 10)
                        rounded /= 10;
                    result = result + dict[rounded * 10];
                    if (num % 10 != 0)
                        result = result + dict[num % 10];
                    return result;
                }
            }
            if (num < 100)
            {
                num = rounded;
                while (rounded >= 10)
                    rounded /= 10;
                result = result + dict[rounded * 10];
                if (num % 10 != 0)
                    result = result + dict[num % 10];
            }
            return result;
        }
    }
}
