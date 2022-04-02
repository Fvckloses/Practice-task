using System;

namespace Task_3_1_
{
    internal class Program
    {
        static double max(double a, double b)
        {
            return (a > b) ? a : b;
        }
        static void Main(string[] args)
        {
            Console.Write("x=");
            double x = double.Parse(Console.ReadLine());
            double z = max((Math.Pow(x,3)) - (Math.Sin(x)), (Math.Pow(x, 3)) + (Math.Sin(x)));
            Console.WriteLine("z=" + z);
            var p = max(x, z);
            Console.WriteLine(p);
        }
    }
}
