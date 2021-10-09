using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            // Сформировать двумерный массив размера NxN, проверить является ли он магическим.
            Console.WriteLine("Введите целочисленное значение N");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[n, n];
            int i = 0;
            int j = 0;
            int k = 0;
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            int sum4 = 0;
            int sumTot = 0;
            int magicConst = ((n * (n * n + 1)) / 2);

            Console.WriteLine("Ранг массива = " + n);
            Console.WriteLine();

            Console.WriteLine("Введите значения элементов для заполнения массива");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    k = Convert.ToInt32(Console.ReadLine());
                    array[i, j] = k;
                }
            }
            Console.WriteLine();

            Console.WriteLine("Массив вида N x N");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0} ", array[i, j]);

                }
                Console.WriteLine();
            }

            /////////////////////

            if (n == 2) sumTot++;

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    sum1 += array[i, j];
                }

                if (magicConst != sum1)
                {
                    sumTot++;
                    break;
                }
                sum1 = 0;
            }

            for (j = 0; j < n; j++)
            {
                for (i = 0; i < n; i++)
                {
                    sum2 += array[i, j];
                }

                if (magicConst != sum2)
                {
                    sumTot++;
                    break;
                }
                sum2 = 0;
            }

            for (i = 0, j = 0; i < n & j < n; i++, j++)
            {
                sum3 += array[i, j];
            }
            if (magicConst != sum3)
            {
                sumTot++;
            }

            for (i = 0, j = n - 1; i < n & j > -1; i++, j--)
            {
                sum4 += array[i, j];
            }
            if (magicConst != sum4)
            {
                sumTot++;
            }

            if (sumTot > 0 && n == 2)
            {
                Console.WriteLine("Квадрат c рангом 2 не является \"магическим\"");
            }

            if (sumTot > 0 && n != 2)
            {
                Console.WriteLine("Квадрат не является \"магическим\"");
            }

            else if (n == 1)
            {
                Console.WriteLine("Квадрат является \"магическим\" - тривиальный случай");
            }

            else if (sumTot == 0 && n != 2)
            {
                Console.WriteLine("Квадрат является \"магическим\" ");
            }
            Console.ReadKey();
        }
    }
}
