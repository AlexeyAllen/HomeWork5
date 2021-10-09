using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fist5_Second5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию.
            int[] array = new int[10];
            Random random = new Random();
            int i = 0;
            int j = 0;
            int k = 0;
            int temp = 0;
            int max = -50;
            int min = 50;

            Console.WriteLine("Неформатированный вывод массива 10 чисел:");
            for (i = 0; i < 10; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();

            for (i = 0; i < 5; i++)
            {

                for (j = i; j < 5; j++)
                {
                    if (array[j] < min)
                    {
                        min = array[j];
                        k = j;
                    }
                }

                temp = array[i];
                array[i] = array[k];
                array[k] = temp;
                min = 50;
            }

            for (i = 5; i < array.Length; i++)
            {

                for (j = i; j < array.Length; j++)
                {
                    if (array[j] > max)
                    {
                        max = array[j];
                        k = j;
                    }
                }

                temp = array[i];
                array[i] = array[k];
                array[k] = temp;
                max = -50;
            }

            Console.WriteLine("Форматированный вывод: ");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0} ", array[i]);
            }

            Console.ReadKey();
        }
    }
}
