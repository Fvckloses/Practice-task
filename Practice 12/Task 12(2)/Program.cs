using System;

namespace Task_12_2_
{
    public delegate int Calculated(int a, int b);
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите действие--> +,-,*,/");
            string a = Console.ReadLine();
            Console.WriteLine("Первое число -->");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Второе число -->");
            int y = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case "+":
                    Calculated calc = (c, b) => c + b;
                    int del = calc(x, y);
                    Console.WriteLine("Ответ:{0}", del);
                    break;
                case "-":
                    Calculated calc1 = (c, b) => c - b;
                    int del1 = calc1(x, y);
                    Console.WriteLine("Ответ:{0}", del1);
                    break;
                case "*":
                    Calculated calc2 = (c, b) => c * b;
                    int del2 = calc2(x, y);
                    Console.WriteLine("Ответ:{0}", del2);
                    break;
                case "/":
                    Calculated calc3 = (c, b) => b == 0 ? 0 : c / b;
                    int del3 = calc3(x, y);
                    Console.WriteLine("Ответ:{0}", del3);
                    break;
            }
            Console.ReadKey();
        }
    }
}
