using System;

namespace Task_1_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите через Enter числа M и N");
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int s = m / n;
            if (m % n == 0)
                Console.WriteLine(s);
            else
                Console.WriteLine("M на N не делится");
        }
    }
}
