using System;

namespace Library17_2
{
    public abstract class Furniture
    {
        public abstract void Opisanie();
        public class Chair : Furniture
        {
            public Chair(bool spinka, bool sidenie,bool nozhki)
            {
                this.Spinka = spinka;
                this.Sidenie = sidenie;
                this.Nozhki = nozhki;
            }
            public bool Spinka;
            public bool Sidenie;
            public bool Nozhki;
            public override void Opisanie()
            {
                if (Spinka == false)
                {
                    Console.WriteLine("Спинка: нет");
                }
                else 
                {
                    Console.WriteLine("Спинка: есть");
                }
                if (Sidenie == false)
                {
                    Console.WriteLine("Сидушка: нет");
                }
                else 
                {
                    Console.WriteLine("Сидушка: есть");
                }
                if (Nozhki == false)
                {
                    Console.WriteLine("Ножки: нет");
                }
                else 
                {
                    Console.WriteLine("Ножки: есть");
                }
            }
        }
        public class Table : Furniture
        {
            public Table(bool stol, bool nozhki)
            {
                this.Stol = stol;
                this.Nozhki = nozhki;
            }
            public bool Stol;
            public bool Nozhki;
            public override void Opisanie()
            {
                if (Stol == false)
                {
                    Console.WriteLine("Столешница: нет");
                }
                else
                {
                    Console.WriteLine("Столешница: есть");
                }
                if (Nozhki == false)
                {
                    Console.WriteLine("Ножки: нет");
                }
                {
                    Console.WriteLine("Ножки: есть");
                }
            }
        }
    }
}
