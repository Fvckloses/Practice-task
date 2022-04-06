using System;

namespace Task_9_1_
{
    internal class Program
    {
        interface Ix
        {
            void IxF0();
            void IxF1();
        }
        interface Iy
        {
            void F0();
            void F1();
        }
        interface Iz
        {
            void F0();
            void F1();
        }
        class TestClass : Ix, Iy, Iz
        {
            string text = "";
            public void F0()
            {
                Console.WriteLine("*");
            }

            public void F1()
            {
                Console.WriteLine("5");
            }

            public void IxF0()
            {
                Console.WriteLine(text.ToLower());
            }

            public void IxF1()
            {
                Console.WriteLine(text.ToUpper());
            }

            public void metod()
            {
                Console.Write("Введите символ: ");
                text = Console.ReadLine();
                if (text == "*")
                {
                    F0();
                }
                else
                {
                    F1();
                }
                Console.Write("Преобразование в нижний регистр: ");
                IxF0();
                Console.Write("Преобразование в верхний регистр: ");
                IxF1();
            }
        }
        static void Main(string[] args)
        {
            TestClass test = new TestClass();
            test.metod();
        }
    }
}
