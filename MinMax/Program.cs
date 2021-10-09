using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            // Определить сумму максимального и минимального элементов массива.
            int[] array = new int[15];
            Random random = new Random();
            int max = 0;
            int min = 50;

            for (int i = 0; i < 15; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write("{0} ", array[i]);

                if (array[i] > max) max = array[i];
                if (array[i] < min) min = array[i];
            }

            Console.WriteLine("max= {0}; min = {1}", max, min);
            Console.ReadKey();
        }
    }
}
