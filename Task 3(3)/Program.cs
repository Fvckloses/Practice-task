using System;

namespace Task_3_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            double x = int.Parse(Console.ReadLine());
            Console.Write("Введите a: ");
            double a = int.Parse(Console.ReadLine());

            double y = RetY(x, a);

            Console.WriteLine("\nЕсли x = " + x + " и a = " + a + ", то y = " + y);
            Console.ReadKey();
        }
        static double RetY(double x, double a)
        {
            if (x < a)
                return 0;
            else if (x > a)
                return (x - a) / (x + a);
            else
                return 1;
        }
    }
}
