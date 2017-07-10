//Problem 8
//The four adjacent digits in the 1000-digit number that have the greatest product are 9 × 9 × 8 × 9 = 5832
//(See Euler8.txt for 1000 digit number)
//Find the thirteen adjacent digits in the 1000-digit number that have the greatest product. What is the value of this product
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Euler8
    {
        public static ulong euler_8()
        {
            const int ADJ_NUM = 13; 
            FileStream  file = new FileStream("Euler8.txt", FileMode.Open);
            StreamReader data = new StreamReader(file);
            string str, num = "";
            while ((str = data.ReadLine()) != null)
            {
                num = num + str;
            }

            List<string> list = new List<string>();
            int start = 0;
            string result;

            while (start < num.Length - (ADJ_NUM -1))
            {
                result = (num.Substring(start, ADJ_NUM));
                //if (!(num.Substring(start, 13).Contains("0"))) //988 vs 263 with this line
                    list.Add(result);
                start = start + 1;
                //Console.WriteLine("start: {0}, end: {1}, result: {2}", start, end, result);
            }

            int[] numsArray2 = new int[ADJ_NUM];
            ulong product = 1;
            ulong highest = 0;
            foreach (var item in list)
	        {
                int[] numsArray = new int[ADJ_NUM];
                for (int i = 0; i < ADJ_NUM; i++)
                {
                    numsArray[i] = int.Parse (item.Substring(i, 1));
                }
                //Console.ReadLine();
                product = 1;
                foreach (ulong i in numsArray )
                {
                    product = product * i;
                }
                if (product > highest)
                {
                    highest = product;
                }
	        }
            return highest;
        }

        private static void print_array(int[] intArray)
        {
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write("{0}  ",intArray[i]);
            }
        }

        private static int array_product(int[] intArray)
        {
            int product = 1;
            for (int i = 0; i < intArray .Length ; i++)
            {
                product = product * intArray[i];
            }
            return product;
        }
    }
}