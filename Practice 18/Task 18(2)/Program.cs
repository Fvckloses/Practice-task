using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Task_18_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2, b = 6;
            Queue<int> fromAToB = new Queue<int>();
            Queue<int> lessThenA = new Queue<int>();
            Queue<int> moreThenB = new Queue<int>();
            int number;
            using (StreamReader reader = new StreamReader(@"18.txt", Encoding.Default))
            {
                while (!reader.EndOfStream)
                {
                    number = int.Parse(reader.ReadLine());
                    if (number < a)
                        lessThenA.Enqueue(number);
                    else if (number > b)
                        moreThenB.Enqueue(number);
                    else
                        fromAToB.Enqueue(number);
                }
            }
            Console.WriteLine(string.Join(" ", fromAToB));
            Console.WriteLine(string.Join(" ", lessThenA));
            Console.WriteLine(string.Join(" ", moreThenB));
        }
    }
}