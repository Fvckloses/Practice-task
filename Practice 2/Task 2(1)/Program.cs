using System;

namespace Task_2_1_
{
    public class A
    {
        public int a;
        public int b;

        public double FuncCalc(int a, int b)
        {
            return Math.Sqrt(Math.Sqrt(a)) + Math.Sqrt(Math.Sqrt(b));

        }

        public A(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа a и b через Enter");
            A a = new A(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

            Console.WriteLine($"Подсчёт функции: { a.FuncCalc(a.a, a.b)}");
        }
    }
}
