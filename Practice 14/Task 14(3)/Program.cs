using System;
using System.Threading;

namespace Task_14_3_
{
    class Program
    {
        static void First(int a)
        {
            double sum = 0;
            for (int i = 1; i < 10; i++)
            {
                sum = sum + Math.Pow(a, i);
                Console.WriteLine($"Метод 1: {sum}");
            }
        }
        static void Second(double a)
        {
            double multiplication = 1;
            for (int j = 1; j < 10; j++)
            {
                multiplication = multiplication * Math.Pow(a, j);
                Console.WriteLine($"Метод 2: {multiplication}");
            }
        }
        static void Main(string[] args)
        {
            int a;
            Console.Write("Введите А: ");
            a = Convert.ToInt32(Console.ReadLine());
            int n;
            Console.Write("Введите N: ");
            n = Convert.ToInt32(Console.ReadLine());
            Thread thread1 = new Thread(() => First(a));
            Thread thread2 = new Thread(() => Second(n));
            Thread thread3 = new Thread(() => First(a));
            thread1.Start();
            thread2.Start();
            thread3.Start();
            Console.ReadLine();
        }
    }
}
