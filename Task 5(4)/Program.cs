using System;

namespace Task_5_4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sr = 0, sum = 0;
            int[,] array = new int[10, 10];
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    array[i, j] = rnd.Next(1, 10);
                }
            }
            Console.WriteLine("Среднемесячный доход какого магазина рассчитать?");
            int x = int.Parse(Console.ReadLine());
            x--;
            for (int i = 0; i < 10; i++)
            {
                if (x == i)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        sum += array[i, j];
                    }
                    sr = sum / 10;
                }
            }
            Console.WriteLine("Среднемесячный доход {0} магазина рассчитать = {1}", ++x, sr);
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
