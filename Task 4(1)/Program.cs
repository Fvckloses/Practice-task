using System;

namespace Task_4_1_
{
    internal class Program
    {
        static double y1(int x)
        {
            return ((Math.Sin(x) / x - 5) + (Math.Pow(x,3)));
        }

        static double y2(double x)
        {
            return (Math.Log10(x) + (Math.Cos(x) / 3 * x + 6));
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите значение Х2: ");
                int x2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"Результат формулы y2: " + y2(x2));
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message, ex.StackTrace);
            }
            try
            {

                Console.WriteLine("Введите значение Х1: ");
                int x1 = int.Parse(Console.ReadLine());
                Console.WriteLine($"Результат формулы y1: " + y1(x1));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message, ex.StackTrace);
            }
            Console.ReadLine();
        }
    }
}
