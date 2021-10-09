using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NxNtype
{
    class Program
    {
        static void Main(string[] args)
        {
            // Сформировать двумерный массив размера NxN указанного вида.
            Console.WriteLine("Введите целочисленное значение N");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];

            for (int i = 0; i < n; i += 2)
            {
                for (int j = 0; j < n; j += 2)
                {
                    array[i, j] = 1;
                }
            }

            for (int i = 1; i < n; i += 2)
            {
                for (int j = 1; j < n; j += 2)
                {
                    array[i, j] = 1;
                }
            }

            Console.WriteLine("Массив вида N x N");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", array[i, j]);

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
