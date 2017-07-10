using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Euler
{
    class Euler16
    {
        public static ulong euler_16()
        {
            BigInteger value = BigInteger.Pow(2, 1000);
            string str = Convert.ToString(value);
            return Convert .ToUInt64(sumdigits (str));
        }
        public static int sumdigits(string str)
        {
            int result = 0;
            for (int i = 0; i < str.Length; i++)
            {
                result = result + Convert.ToInt32(str.Substring(i, 1));
            }
            return result;
        }
    }
}
