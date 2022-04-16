using System;

namespace Task_17_2_
{
    using Library17_2;
    internal class Program
    {  
        static void Main(string[] args)
        {
            Console.WriteLine("Описание стула: 0 - нет, 1 - есть");
            Console.WriteLine("Опишите цифрами через enter наличие этих компонентов: \n -Спинка \n -Сиденье \n -Ножки");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            if (a == "1")
            {
                a = "true";
            }
            else if (a == "0")
            {
                a = "false";
            }
            if (b == "1")
            {
                b = "true";
            }
            else if (b == "0")
            {
                b = "false";
            }
            if (c == "1")
            {
                c = "true";
            }
            else if (c == "0")
            {
                c = "false";
            }
            Furniture[] chair = new Furniture[1];
            chair[0] = new Furniture.Chair.Chair(Convert.ToBoolean(a), Convert.ToBoolean(b), Convert.ToBoolean(c));
            foreach (Furniture elem in chair)
            {
                elem.Opisanie();
            }
            Console.WriteLine();
            Console.WriteLine("Описание стола: 0 - нет, 1 - есть");
            Console.WriteLine("Опишите цифрами через enter наличие этих компонентов: \n -Столешница \n -Ножки");
            string a1 = Console.ReadLine();
            string b1 = Console.ReadLine();
            if (a1 == "1")
            {
                a1 = "true";
            }
            else if (a1 == "0")
            {
                a1 = "false";
            }
            if (b1 == "1")
            {
                b1 = "true";
            }
            else if (b1 == "0")
            {
                b1 = "false";
            }
            Furniture[] table = new Furniture[1];
            table[0] = new Furniture.Table.Table(Convert.ToBoolean(a1), Convert.ToBoolean(b1));
            foreach (Furniture elem1 in table)
            {
                elem1.Opisanie();
            }
        }
    }
}
