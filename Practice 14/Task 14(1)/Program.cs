using System;
using System.Threading;

namespace Task_14_1_
{
    internal class Program
    {
        static void FirstThread()
        {
            for (int i = 0; i <= 10; i++)
            {
                Thread.Sleep(20);
                Console.WriteLine($"Первый поток говорит: {i} ");
            }
        }
        static void SecondThread()
        {
            for (int i = 10; i <= 19; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine($"Второй поток говорит: {i} ");
            }
        }
        static void ThirdThread()
        {
            for (int i = 20; i <= 29; i++)
            {
                Thread.Sleep(90);
                Console.WriteLine($"Третий поток говорит: {i} ");
            }
        }
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(FirstThread));
            Thread thread2 = new Thread(new ThreadStart(SecondThread));
            Thread thread3 = new Thread(new ThreadStart(ThirdThread));
            thread1.Priority = ThreadPriority.Highest;
            thread2.Priority = ThreadPriority.Normal;
            thread3.Priority = ThreadPriority.Normal;
            thread1.Start();
            thread2.Start();    
            thread3.Start();
            Thread.Sleep(1000);
            Console.WriteLine("Главный поток молчит");
            Console.WriteLine("Главный поток завершён");
            Console.ReadLine();
        }
    }
}
