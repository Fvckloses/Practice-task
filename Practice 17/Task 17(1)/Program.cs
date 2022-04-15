using System;

namespace Task_17_1_
{
    using Library17;
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            Console.WriteLine("Стороны треугольника: (a,b,c), Стороны прямоугольника: (a,b)");
            Console.Write("Введите сторону а: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сторону b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сторону c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Figures[] fig = new Figures[n];
            fig[0] = new Figures.Triangle.Triangle(a, b, c);
            fig[1] = new Figures.Rectangle.Rectangle(a, b);
            foreach (Figures elem in fig)
            {
                elem.Sr();
                elem.ravn();
            }
        }
    }
}
