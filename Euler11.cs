//Problem 11 Largest Product in a Grid
//In the 20×20 grid below, four numbers along a diagonal line have been marked in red.

// Euler11.txt

//The product of these numbers is 26 × 63 × 78 × 14 = 1788696.

//What is the greatest product of four adjacent numbers in the same direction (up, down, left, right, or diagonally) in the 20×20 grid?

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Euler11
    {
        const int ARRAYSIZE = 20;

        public static ulong euler_11()
        {
            ulong result = 0;
            FileStream f_in = new FileStream("Euler11.txt", FileMode.Open);
            StreamReader file = new StreamReader(f_in);
            string str = "";
            string temp;

            //Make our array from the file
            while ((temp = file.ReadLine()) != null)
            {
                str = str + temp + " ";
            }
            int[,] gridArray = generateArray(str);
            List<int[]> list = generate_quads(gridArray);
            result = highest_quad(list);
            file.Close();
            return (result);
        }

        private static ulong highest_quad(List<int[]> list)
        {
            ulong result = 0;
            ulong temp = 0;
            foreach (int[] item in list)
            {
                temp = Convert.ToUInt64(item[0] * item[1] * item[2] * item[3]);
                if (temp > result)
                    result = temp;
            }
            return result;
        }

        private static void print_list(List<int[]> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine("a: {0}, b: {1}, c: {2}, d: {3}"
                    , item[0], item[1], item[2],
                    item[3]);
            }
            Console.WriteLine("list length: {0}", list.Count);
        }

        private static List<int[]> generate_quads(int[,] gridArray)
        {
            int[] quadArray;
            List<int[]> list = new List<int[]>();
            //vertical
            for (int y = 0; y < ARRAYSIZE; y++)
            {
                for (int x = 0; x < ARRAYSIZE - 3; x++)
                {
                    quadArray = new int[4] { gridArray[x, y], gridArray[x + 1, y], gridArray[x + 2, y], gridArray[x + 3, y]};
                    list.Add(quadArray);
                }
            }
            //horizontal
            for (int x = 0; x < ARRAYSIZE; x++)
            {
                for (int y = 0; y < ARRAYSIZE - 3; y++)
                {
                    quadArray = new int[4] { gridArray[x, y], gridArray[x, y + 1], gridArray[x, y + 2], gridArray[x, y + 3] };
                    list.Add(quadArray);
                }
            }
            //increasing diagonals
            for (int x = 0; x < ARRAYSIZE - 3; x++)
            {
                for (int y = 0; y < ARRAYSIZE - 3; y++)
                {
                    quadArray = new int[4] { gridArray[x, y], gridArray[x + 1, y + 1], gridArray[x + 2, y + 2], gridArray[x + 3, y + 3] };
                    list.Add(quadArray);
                }
            }
            //inverted diagonals
            for (int x = 3; x < ARRAYSIZE; x++)
            {
                for (int y = 0; y < ARRAYSIZE - 3; y++)
                {
                    quadArray = new int[4] { gridArray[x, y], gridArray[x - 1, y + 1], gridArray[x - 2, y + 2], gridArray[x - 3, y + 3] };
                    list.Add(quadArray);
                }
            }
            return list;
        }

        private static void printArray(int[,] gridArray)
        {
            for (int i = 0; i < ARRAYSIZE ; i++)
            {
                for (int k = 0; k < ARRAYSIZE; k++)
                {
                    Console.Write(gridArray[i, k] + " ");
                    if (gridArray[i, k] < 10) Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        private static int[,] generateArray(string str)
        {
            int start = 0;
            int[,] gridArray = new int[ARRAYSIZE, ARRAYSIZE];
            for (int i = 0; i < ARRAYSIZE ; i++)
            {
                for (int j = 0; j < ARRAYSIZE; j++)
                {
                    gridArray[i, j] = Convert.ToInt32(str.Substring(start, 2));
                    start = start + 3;
                }
            }
            return gridArray;
        }
    }
}
