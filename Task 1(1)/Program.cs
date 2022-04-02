using System;

namespace Task_1_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double y;
            const double e = 2.71;
            Console.WriteLine("Введите значение x");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x >= 1 & x <= 3)
            {
                y = 2 * Math.Pow(x, 2) - 3 * Math.Pow(e, Math.Sin(x));
                Console.WriteLine(y);
            }
            else if (x > 3)
            {
                y = 3 * Math.Tan(x);
                Console.WriteLine(y);
            }
        }
    }
}
