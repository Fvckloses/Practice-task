using System;
using System.Text.RegularExpressions;

namespace Task_7_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            Console.Write("Введите длину слова: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Слов с количеством букв {length}: {GetWord(length, text)}");
        }
        private static int GetWord(int length, string text)
        {
            string pattern = $@"\b[\w\d]{{{length}}}\b";
            MatchCollection коллекция = Regex.Matches(text, pattern);
            return коллекция.Count;
        }
    }
}
