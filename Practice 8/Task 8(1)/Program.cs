using System;

namespace Task_8_1_
{
    internal class Program
    {
        struct AEROFLOT
        {
            public string destination, type;
            public int number;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество рейсов: ");
            int m = Convert.ToInt32(Console.ReadLine());
            AEROFLOT[] mass = new AEROFLOT[m];
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine("Введите пункт назначения");
                mass[i].destination = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите номер рейса");
                mass[i].number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите тип самолёта");
                mass[i].type = Convert.ToString(Console.ReadLine());
                Console.WriteLine();
            }
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine("AEROFLOT" + " " + i + ":");
                Console.WriteLine("Пункт назначения: " + mass[i].destination);
                Console.WriteLine("Номер рейса: " + mass[i].number);
                Console.WriteLine("Тип самолёта: " + mass[i].type);
                Console.WriteLine();
            }
            Console.Write("Введите номер AEROFLOT: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine();
                Console.WriteLine("AEROFLOT" + " " + n + ":");
                Console.WriteLine("Пункт назначения: " + mass[n].destination);
                Console.WriteLine("Номер рейса: " + mass[n].number);
                Console.WriteLine("Тип самолёта: " + mass[n].type);
                Console.ReadKey();
            }
        }
        static void Sort(AEROFLOT[] mass)
        {
            AEROFLOT buf;
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = i + 1; j < mass.Length; j++)
                {
                    buf = mass[i];
                    mass[i] = mass[j];
                    mass[j] = buf;
                }
            }
        }
    }
}
