using System;

namespace Task_11_1_
{
    internal class Building
    {
        public string name;
        public Building()
        {
            this.name = null;
        }
        public virtual void Input()
        {
            Console.Write("Введите название кампании: ");
            name = Console.ReadLine();
        }
        public virtual void GetInfo()
        {
            Console.WriteLine("Название: {0}", name);
        }
    }
}