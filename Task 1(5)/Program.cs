using System;

namespace Task_1_5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());

            double result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= a;
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }
    }
}
