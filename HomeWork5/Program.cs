using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            // Определить среднее арифметическое элементов одномерного массива из 7 элементов.
            int[] array = new int [7];
            int avg1 = 0;
            double avg2 = 0;

            for (int i = 0; i < 7; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                avg1 += array[i];
            }

            avg2 = (double) avg1 / 7;

            Console.WriteLine("Среднее арифметическое элементов массива = {0:f2}", avg2);
            Console.ReadKey();

        }
    }
}
