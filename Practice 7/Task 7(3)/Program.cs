using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Task_7_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();
            Regex regex = new(@"[a-z\w] [\wa-z]");
            MatchCollection matches = regex.Matches(str);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    Console.WriteLine(match.Value);
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }
        }
    }
}
