using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task_19_3_
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Вывод текста из файла");
            Print();
            Console.WriteLine("--------------");
            var filePath = @"first.txt";
            var filePath1 = @"second.txt";
            int count = File.ReadAllLines(filePath).Length;
            Console.WriteLine($"Количество строк: {count}");
            var numbers = SymCount(filePath);
            int i = 1;
            foreach (var num in numbers)
            {
                Console.WriteLine($"Кол-во символов в {i} строке: {num.ToString()}");
                i++;
            }
            Console.WriteLine("\nУдаление последней строки и запись результата в другой файл");
            DeleteStringAndWrite(filePath, filePath1);
            Console.WriteLine("--------------");
            S1toS2(filePath, 1, 3);
            LongString(filePath);
            FirstLetterLine(filePath, 'в');
            ReverseFile(filePath);
            Console.ReadKey();
        }
        /// <summary>
        /// Создание нового файла
        /// </summary>
        /// <param name="path"></param>
        private static void ReverseFile(string path)
        {
            string pathoutput = @"Reverse.txt";
            File.WriteAllLines(pathoutput, File.ReadAllLines(path).Reverse());
        }
        /// <summary>
        /// возврат текста по первой букве
        /// </summary>
        /// <param name="path"></param>
        /// <param name="firstChar"></param>
        /// <returns></returns>
        private static string FirstLetterLine(string path, char firstChar)
        {
            return Convert.ToString(File.ReadAllLines(path).Where(s => s[0] == firstChar));
        }
        /// <summary>
        /// вывод длинной строки
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private static string LongString(string path)
        {
            return Convert.ToString(File.ReadAllLines(path).Where(s => s.Length == File.ReadAllLines(path).Max(m => m.Length)).First());
        }
        /// <summary>
        /// вывод строк по номеру
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="fromS1"></param>
        /// <param name="toS2"></param>
        /// <returns></returns>
        private static string S1toS2(string filePath, int fromS1, int toS2)
        {
            return Convert.ToString(File.ReadAllLines(filePath).Skip(fromS1).Take(File.ReadAllLines(filePath).Length - toS2));
        }
        /// <summary>
        /// удаление строки из первого файла и занесение остального текста в другой файл
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="filePath1"></param>
        private static void DeleteStringAndWrite(string filePath, string filePath1)
        {
            string[] readText = File.ReadAllLines(filePath);
            string[] writeText = new string[readText.Length - 1];
            Array.Copy(readText, 0, writeText, 0, readText.Length - 1);
            File.WriteAllLines(filePath1, writeText);
        }
        /// <summary>
        /// вывод строки с самым большим количеством символов
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private static List<int> SymCount(string filePath)
        {
            var countsCharInLines = new List<int>();
            using (var reader = new StreamReader(filePath, detectEncodingFromByteOrderMarks: true))
            {
                var line = String.Empty;
                while ((line = reader.ReadLine()) != null)
                {
                    var count = line.Length;
                    countsCharInLines.Add(count + 1);
                }
            }
            return countsCharInLines;
        }
        /// <summary>
        /// вывод текста
        /// </summary>
        private static void Print()
        {
            try
            {
                using (StreamReader sr = new StreamReader("first.txt"))
                {
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                    sr.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Исключение: " + e.Message);
            }
        }
    }
}
