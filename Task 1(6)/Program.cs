using System;

namespace Task_1_6_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int m = 10;
            const int a = 0;
            const double b = Math.PI / 4;
            const double n = 2.1;
            const double e = 2.71;

            Console.WriteLine("Введите значение x ");
            double x = Convert.ToDouble(Console.ReadLine());
            x = Math.Tan(x);
            double H = (b - a) / m;
            
            for (double i = 0.1; i<=n ; i += 0.1)
            {
                double y = Math.Pow(x, 2) - Math.Pow(e, x);
                x = x + H;
                Console.WriteLine(y);
            }
        }
    }
}
