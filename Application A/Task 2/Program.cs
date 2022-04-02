using System;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp, k;
            Console.WriteLine("Введите трёхзначное число ");
            k = Convert.ToInt16(Console.ReadLine());
            temp = k;
            k = k / 100;
            temp = temp % 100;
            k = temp * 10 + k;
            Console.WriteLine($"Полученное трехзначное число: {k}");
        }
    }
}
