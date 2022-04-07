using System;

namespace Task_10_1_
{
    internal class Animal
    {
        private string name;
        private double h;
        private double income;
        private double k;
        public Animal()
        {
            name = null;
            h = 0;
            income = 0;
            k = 0;
            Input();
        }
        public void GetInfo()
        {
            Console.WriteLine("Имя:{0} | Минимальная зарплата:{1} | Повышающий коэффициент:{2}", name, H, k);
        }
        public virtual void IncomePay()
        {
            income = k * h;
        }
        public string Name { get { return name; } set { name = value; } }
        public double H { get { return h; } set { h = value; } }
        public double K { get { return k; } set { k = value; } }
        public double Income { get { return income; } set { income = value; } }
        public void Input()
        {
            Console.Write("Введите кличку кошки: ");
            name = Console.ReadLine();
            Console.Write("Введите рост животного в метрах: ");
            h = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите повышающий коэффициент: ");
            k = Convert.ToDouble(Console.ReadLine());
        }
    }
}