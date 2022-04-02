using System;

namespace Task_5_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random rand = new Random((int)DateTime.Now.Ticks);
            int summ = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(100, 201);
                Console.Write("{0}, ", arr[i]);
                summ += arr[i];
            }
            int mid = summ / arr.Length;
            Console.WriteLine();
            Console.WriteLine($"Среднее анифметическое: {mid}");
        }
    }
}
