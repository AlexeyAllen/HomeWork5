using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            // Определить количество нечетных положительных элементов, стоящих на четных местах.

            int[] array = new int[20];
            Random random = new Random();
            int i = 0;
            //int j = 0;
            int k = 0;

            for (i = 0; i < 20; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();

            for (i = 1; i < array.Length; i+=2)
            {
                if (array[i]>0 && (array[i] % 2) != 0)
                {
                    k++;
                }
            }

            Console.WriteLine("Количество нечетных положительных элементов, стоящих на четных местах = {0}", k);
           
            Console.ReadKey();

        }
    }
}
