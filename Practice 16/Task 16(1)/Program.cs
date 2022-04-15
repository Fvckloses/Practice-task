using System;
using System.IO;
using System.Linq;

namespace Task_16_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string path = @"f.txt";
            string[] readText = File.ReadAllLines(path);
            var NumbersInFile = File.ReadAllText("f.txt")
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Replace(".", ","))
                .Select(decimal.Parse);
            Console.WriteLine($"Сумма минимального и максимального элементов: {NumbersInFile.Min() + NumbersInFile.Max()}");
            Directory.CreateDirectory("new_folder");
            Console.WriteLine("содержимое файла");
            Console.WriteLine(readText[0]);
            var sp = readText[0].Split(' ');
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
