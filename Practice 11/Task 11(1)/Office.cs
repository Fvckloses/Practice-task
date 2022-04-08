using System;

namespace Task_11_1_
{
    internal class Office: Building
    {
        public int N;
        public double h;
        public double cost;
        public Office()
        {
            this.N = 0;
            this.h = 0;
            Input();
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Введите количество этажей: ");
            N = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите высоту фундамента: ");
            h = Convert.ToDouble(Console.ReadLine());
        }
        public virtual void CostOffice()
        {
            cost = 0.05 * N;
        }
        public override void GetInfo()
        {
            CostOffice();
            Console.WriteLine("Название: {0} \nВысота фундамента: {1} \nКоличество этажей: {2} \nСтоимость: {3}", name, h, N, cost);
        }
    }
}