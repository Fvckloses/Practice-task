using System;

namespace Task_20_3_
{
    internal class Program
    {
        static int digitsSum(int n)
        {
            int sum = 0;
            while (n != 0)
            { 
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }
        static void Main()
        {
            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Cумма чисел: " + digitsSum(n));
            Console.ReadLine();
        }
    }
}
