using System;

namespace Task_1_4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Все целые числа из диапазона от А до В(А <= В), оканчивающиеся на цифру Х
            Console.Title = "Программа для работы с циклами for, while, do while";

            Console.Write("Введите число X = ");
            int X = int.Parse(Console.ReadLine());
            Console.Write("Введите начальный диапазон = ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Введите конечный диапазон = ");
            int B = int.Parse(Console.ReadLine());
            while (A % 10 != X)
            {
                A++;
            }
            while (B % 10 != X)
            {
                B--;
            }
            int i;
            Console.WriteLine();
            Console.WriteLine("For: ");
            for (i = A; i <= B; i += 10)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine("While: ");
            i = A;
            while (i <= B)
            {
                Console.WriteLine(i);
                i += 10;
            }
            Console.WriteLine();
            Console.WriteLine("Do while: ");
            i = A;
            do
            {
                Console.WriteLine(i);
                i += 10;
            }
            while (i <= B);
            Console.ReadLine();
        }
    }
}
