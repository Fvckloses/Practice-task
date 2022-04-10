using System;
using System.Diagnostics;

namespace Task_13_1_
{
    internal class Program
    {
        delegate void Calculation(int number1, int number2, Action<double> output);
        static void P(int number1, int number2, Action<double> output)
        {
            int res;
            res = (number1 * 2) + (number2 * 2);
            Console.WriteLine("Периметр прямоугольника: ");
            output(res);
        }
        static void S(int number1, int number2, Action<double> output)
        {
            int res;
            res = number1 * number2;
            Console.WriteLine("Площадь прямоугольника: ");
            output(res);
        }
        static void Side(int number1, int number2, Action<double> output)
        {
            int res;
            res = number1;
            Console.WriteLine("Сторона треугольника: ");
            output(res);
        }
        static void Main(string[] args)
        {
            var consoleListener = new ConsoleTraceListener();
            var fileListener = new TextWriterTraceListener("log.txt");
            Trace.Listeners.Add(consoleListener);
            Trace.Listeners.Add(fileListener);
            Trace.AutoFlush = true;
            int number1 = 5;
            int number2 = 7;
            Calculation ab = P;
            ab += S;
            ab += Side;
            ab(number1, number2, (n) => Trace.WriteLine(n));
            Console.ReadLine();
        }
    }
}
