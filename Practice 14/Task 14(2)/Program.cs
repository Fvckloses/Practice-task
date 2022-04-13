using System;
using System.Threading;

namespace Task_14_2_
{
    internal class Program
    {
        static void FirstThread()
        {
            for (int i = 0; i <= 10; i++)
            {
                Thread.Sleep(10);
                int sum = 0;
                sum = sum + i;
                Console.WriteLine(sum);
            }
        }
        static void SecondThread()
        {
            for (int i = 0; i <= 10; i++)
            {
                Thread.Sleep(10);
                int sum = 0;
                sum = sum + i;
                Console.WriteLine(sum);
            }
        }
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(FirstThread));
            Thread thread2 = new Thread(new ThreadStart(SecondThread));
            thread1.Start();
            thread2.Start();
            Console.ReadLine();
        }
    }
}
