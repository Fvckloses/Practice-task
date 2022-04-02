using System;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 4.3;
            double y = (1 + Math.Sqrt(Math.Abs(3 - (x * x)))) / (Math.Atan(x * x));
            Console.WriteLine(y);
        }
    }
}
