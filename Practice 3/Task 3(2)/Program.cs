using System;

namespace Task_3_2_
{
    internal class Program
    {
        static double f (double x)
        {
            double y;
            if (Math.Abs(x) <= 0.1) y = Math.Pow(x,3) - 0.1;
            else if (x <= 0.2 & x > 0.1) y = 0.2 * x - 0.1;
            else y = Math.Pow(x,3) + 0.1;
            return y;
        }
        static void Main(string[] args)
        {
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse (Console.ReadLine());
            Console.Write("h=");
            double h = double.Parse(Console.ReadLine());
            for (double i = a; i <= b; i += h)
                Console.WriteLine("f({0:f2})=(1:f4)", i, f(i));
        }
    }
}
