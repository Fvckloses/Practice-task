using System;

namespace Task_1_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("а - автомобиль");
            Console.WriteLine("в - велосипед");
            Console.WriteLine("м - мотоцикл");
            Console.WriteLine("с - самолёт");
            Console.WriteLine("п - поезд");
            Console.WriteLine("Введите букву транспортного средства, чтобы узнать его максимально допустимую скорость");
            string vehicle = Convert.ToString(Console.ReadLine());
            if (vehicle == "а")
                Console.WriteLine("120 км/ч");
            else if (vehicle == "в")
                Console.WriteLine("60 км/ч");
            else if (vehicle == "м")
                Console.WriteLine("120 км/ч");
            else if (vehicle == "с")
                Console.WriteLine("917 км/ч");
            else if (vehicle == "п")
                Console.WriteLine("141 - 200 км/ч");
            else
                Console.WriteLine("Данного транспортного средства нет в списке");
        }
    }
}
