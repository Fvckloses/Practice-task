using System;

namespace Task_4_3_
{
    class Triangle
    {
        private double _a;

        public Triangle(double a)
        {
            this._a = a;
        }
        public double P(double a)
        {
            return (3 * a);
        }
        public double S(double a)
        {
            return (Math.Pow(a,2) * (Math.Sqrt(3) / 4));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tri = new Triangle(2);
            Console.WriteLine($"периметр = {tri.P(2)}");
            Console.WriteLine($"площадь = {tri.S(2)}");
        }
    }
}
