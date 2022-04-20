using System;
using System.Threading.Tasks;

namespace Task_20_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task task1 = Task.Run(() =>
            {
                Console.Write("Введите число:");
                string str = Console.ReadLine();
                for (int i = str.Length - 1; i >= 0; i--) Console.Write(str[i]);
                Console.WriteLine();
            });
            task1.Wait();
        }
    }
}
