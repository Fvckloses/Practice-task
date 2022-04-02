using System;
using System.Linq;

namespace Task_6_1_
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Введите текст: ");
            string s = Console.ReadLine();
            var arr = s.ToCharArray();
            var qu = arr.Distinct();
            foreach (var z in qu)
            {
                Console.WriteLine("{0} повторяется {1} раз", z, s.Count(c => c == z));
            }
            Console.ReadKey();
        }
    }
}
