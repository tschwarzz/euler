using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Euler
{
    class Euler13
    {
        const int DIGITS_TO_EXTRACT = 17;
        public static ulong euler_13()
        {
            ulong result = 0;
            string temp = "";
            List<ulong> list = new List<ulong>();
            FileStream f_in = new FileStream("Euler13.txt", FileMode.Open);
            StreamReader file = new StreamReader(f_in);

            list = strip(file);
            result = list_sum(list);
            temp = Convert.ToString(result);
            temp = temp.Substring(0, 10);
            result = Convert.ToUInt64(temp);

            return result;
        }

        private static ulong list_sum(List<ulong> list)
        {
            ulong result = 0;

            foreach (var item in list)
            {
                result = result + Convert.ToUInt64 (item);
            }
            return result;
        }

        private static List<ulong> strip (StreamReader file)
        {
            List<ulong> list = new List<ulong>();
            ulong numToAdd = 0;
            string temp = "";
            while ((temp = file.ReadLine()) != null)
            {
                numToAdd = Convert.ToUInt64(temp.Substring(0, DIGITS_TO_EXTRACT));
                list.Add(numToAdd);

            }
            return list;
        }
    }
}
