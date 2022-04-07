using System;

namespace Task_10_2_
{
    internal class Program
    {
        private const double First = 4, Second = -9, Thrid = 77;
        static void Main(string[] args)
        {
            A a = new A(First, Second);
            B b = new B(First, Second, Thrid);
            Console.WriteLine($"a: {a.C}");
            Console.WriteLine($"b: {b.C2}");
        }
    }
}
