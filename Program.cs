using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("One-dimensional array:");
            Calculation[] A = { new Calculation(1, 2), new Calculation(2, 5) };  //створенння одновимірного масиву
            foreach (Calculation f in A) Console.WriteLine(f);
            Console.ReadKey();

            Console.WriteLine("Two-dimensional array:");
            int[,] unit = { { 0, 1, 2 }, { 3, 4, 5 } };
            for (int i = 0; i < unit.GetLength(0); ++i)
            {
                for (int j = 0; j < unit.GetLength(1); ++j)
                    Console.Write("{0,4}", unit[i, j]);
                Console.WriteLine();
                Console.ReadKey();
            }

            Console.WriteLine("Three-dimensional array:");
            int[,,] A3 = {
                    {{12, 2, 8}},
                    {{14, 5, 2}},
                    {{3, 26, 9}},
                    {{4, 11, 2}}
                          };
            int l1 = A3.GetLength(0);
            int l2 = A3.GetLength(1);
            int l3 = A3.GetLength(2);

            for (int i = 0; i < l1; i++)
            {
                for (int j = 0; j < l2; j++)
                {
                    for (int k = 0; k < l3; k++)
                    {
                        Console.Write(A3[i, j, k] + " ");
                    }
                }
            }

            Console.WriteLine("\n");
            Console.WriteLine("Jagged array:");
            int[][] value = new int[5][];
            value[0] = new int[] { 1, 2 };
            value[1] = new int[] { 1, 2, 3 };
            value[2] = new int[] { 1, 2, 3, 4, 5 };
            value[3] = new int[] { 5, 6, 7, 8 };
            value[4] = new int[] { 8, 9 };
            foreach (int[] row in value)
            {
                foreach (int val in row)
                {
                    Console.Write($"{val} \t");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < value.Length; i++)
            {
                for (int j = 0; j < value[i].Length; j++)
                {
                    Console.Write($"{value[i][j]} \t");
                }
                Console.WriteLine();
                Console.ReadKey();
            }

            Console.WriteLine("Array Copy:");
            int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
            int[] numbers2 = new int[5];
            Array.Copy(numbers, 2, numbers2, 0, 5);
            foreach (int number in numbers2)
            {
                Console.Write($"{number} \t");
            }
            Console.Write("\n");

            Console.WriteLine("Array Sort:");
            int[] massif = { 2, 3, 0, 4, 1, 7, 5, 8, 3, 8, 5, 7, 4, 2, 4, 7, 3, 5, 7, 7, 4, 2, 9 };
            for (int i = 0; i < massif.Length; i++)
            {
                Console.Write(massif[i] + " ");
            }
            Array.Sort(massif);
            //Array.Reverse(masiv);
            Console.WriteLine();
            for (int i = 0; i < massif.Length; i++)
            {
                Console.Write(massif[i] + " ");
            }
            Console.Read();
        }

        class Calculation
        {
            private int num;
            private uint den;
            public Calculation(int x, uint y)
            {
                num = x;
                if (y > 0)
                    den = y;
                else den = 1;
            }
            public override string ToString()
            {
                return string.Format("{0}/{1}", num, den);
            }
        }
    }
}















