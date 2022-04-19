using System;

namespace Task_19_1_
{
    internal class Program
    {
        static double funk(double x)
        {
            double y;
            if ((Math.Pow(x, 2) + (2 * x) + 1) < 2) { y = Math.Pow(x, 2); }
            else if ((2 <= Math.Pow(x, 2) + (2 * x) + 1) & ((3 >= Math.Pow(x, 2) + (2 * x) + 1))) { y = 1 / (Math.Pow(x, 2) - 1); }
            else { y = 0; }
            return y;
        }
        /// <summary>
        /// строение последовательности
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("a= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b= ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("h= ");
            double h = double.Parse(Console.ReadLine());
            for (double i = a; i <= b; i += h)
            { Console.WriteLine("({0:f2})={1:f4}" + i + funk(i)); };
        }
    }
}
