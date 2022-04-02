using System;
using System.Text.RegularExpressions;

namespace Task_7_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            var text = Console.ReadLine();
            Console.Write("Введите слово которое есть в тексте: ");
            var word = Console.ReadLine();
            Console.WriteLine($"Количество вхождений: {NumberOfOccurrences(word, text)}");
        }
        private static int NumberOfOccurrences(string word, string text)
        {
            string pattern = $@"\b{word}\b";
            MatchCollection коллекция = Regex.Matches(text, pattern);
            return коллекция.Count;
        }
    }
}
