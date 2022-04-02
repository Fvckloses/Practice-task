using System;
using System.Linq;

namespace Task_5_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число C");
            int c = Convert.ToInt32(Console.ReadLine());
            var rng = new Random();
            Console.WriteLine("Введите размерность матрицы N");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Random rand = new Random((int)DateTime.Now.Ticks);
            double avg = 0;
            double sr = 0;
            Console.WriteLine("Массив: ");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i] = rand.Next(0, 20);
                    avg += array[i];
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Среднее арифметическое каждой строки: ");
            for (int i = 0; i < n; i++)
            {
                int summ = 0;
                for (int j = 0; j < n; j++)
                {
                    summ += array[i];
                    sr = summ / n;
                }
                Console.Write(sr);
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine(
               "Вычислить сумму квадратов элементов больше C = {0}"
              , array.Where(i => i > c).Sum(s => s * s)
            );
        }
    }
}
