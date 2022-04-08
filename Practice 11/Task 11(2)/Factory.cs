using System;

namespace Task_11_2_
{
    internal class Factory: Building
    {
        public int G;
        public double cost;
        public Factory()
        {
            this.G = 0;
            Input();
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Введите вес: ");
            G = Convert.ToInt32(Console.ReadLine());
        }
        public virtual void CostFactory()
        {
            cost = 0.000002 * G;
        }
        public override void GetInfo()
        {
            CostFactory();
            Console.WriteLine("Название: {0} \nВес: {1} \nСтоимость: {2}", name, G, cost);
        }
    }
}