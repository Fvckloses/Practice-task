using System;

namespace Task_12_3_
{
    public delegate string Stroka(string a);
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите действие --> 1.Удалить первое слово, 2.Удалить последнее слово, 3.Удалить пробелы.");
            string a = Console.ReadLine();
            Console.WriteLine("Введите строку --> ");
            string x = Console.ReadLine();
            switch (a)
            {
                case "1":
                    Stroka calc = (c) => c ;
                    string del = x.Remove(0, x.IndexOf(' ') + 1);
                    Console.WriteLine("Ответ:{0}", del);
                    break;
                case "2":
                    Stroka calc1 = (c) => c;
                    string del1 = x.Remove(x.LastIndexOf(' '));
                    Console.WriteLine("Ответ:{0}", del1);
                    break;
                case "3":
                    Stroka calc2 = (c) => c ;
                    string del2 = x.Replace(" ", "");
                    Console.WriteLine("Ответ:{0}", del2);
                    break;
            }
            Console.ReadKey();
        }
    }
}
