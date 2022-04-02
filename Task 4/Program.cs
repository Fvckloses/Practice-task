using System;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты вершины А");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты вершины B");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты вершины C");
            double x3 = Convert.ToDouble(Console.ReadLine());
            double y3 = Convert.ToDouble(Console.ReadLine());
            double a = Math.Sqrt((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2)));
            double b = Math.Sqrt((Math.Pow(x3 - x2, 2)) + (Math.Pow(y3 - y2, 2)));
            double c = Math.Sqrt((Math.Pow(x1 - x3, 2)) + (Math.Pow(y1 - y3, 2)));
            double P = (a + b + c) / 2;
            double S = 1 / 2 * ((x1 - x3) * (y2 - y3) - (x2 - x3) * (y1 - y3));
            Console.WriteLine($"Периметр треугольника: {P}");
            Console.WriteLine($"Площадь треугольника: {S}");
        }
    }
}
