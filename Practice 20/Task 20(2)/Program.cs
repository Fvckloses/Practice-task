using System;
using System.Threading.Tasks;

namespace Task_20_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 2;
            double b = 4;
            Task task1 = new Task(() =>
            {
                double z1 = (Math.Cos(2 * b - a) + Math.Sin(a)) / (Math.Cos(a) - Math.Sin(2 * b - a));
                global::System.Console.WriteLine(z1);
            });
            Task task2 = new Task(() =>
            {
                double z2 = (1 + Math.Sin(2 * b)) / Math.Cos(2 * b);
                global::System.Console.WriteLine(z2);
            });
            task1.Start();
            task2.Start();
            task1.Wait();
            task2.Wait();
        }
    }
}
