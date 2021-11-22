using System;

namespace ArraayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[5, 2] { { 0, 0 }, { 1, 1 }, { 2, 2 }, { 3, 3 }, { 4, 4 } };
            int i, j;
            for (i = 0; i < 5; i++)
            {

                for (j = 0; j < 2; j++)
                {
                    Console.Write(" {0} ", a[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}