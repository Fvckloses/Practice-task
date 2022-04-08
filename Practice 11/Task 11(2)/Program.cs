using System;
using System.Linq;

namespace Task_11_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mascount = 2;
            Building[] build = new Building[mascount];
            Console.WriteLine("Выберите создаваемый объект: ");
            Console.WriteLine("1. Building \n2. Office \n3. Factory");
            int change = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            double costp = 0;
            double costs = 0;
            double Srcostp = 0;
            double Srcosts = 0;
            while (i < mascount)
            {
                switch (change)
                {
                    case 1: build[i] = new Building(); ++i; break;
                    case 2:
                        Office office = new Office();
                        office.CostOffice();
                        costp = costp + office.cost;
                        var max = office.h.Max();
                        build[i] = office as Building; ++i; break;
                    case 3:
                        Factory factory = new Factory();
                        factory.CostFactory();
                        costs = costs + factory.cost;
                        build[i] = factory as Building; ++i; break;
                    default: Console.WriteLine("Нет такого пункта!"); break;
                }
            }
            for (int t = 0; t < build.Length; t++)
            {
                if (build[t] != null)
                {
                    build[t].GetInfo();
                }
            }
            Srcostp = costp / mascount;
            Srcosts = costs / mascount;
            if (Srcostp == 0)
                Console.WriteLine("Средняя стоимость: {0}", Srcosts);
            else Console.WriteLine("Средняя стоимость: {0}", Srcostp);
            Console.ReadLine();
        }
    }
}
