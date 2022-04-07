using System;

namespace Task_10_1_
{
    internal class Cat: Animal
    {
        string n;
        public Cat():base()
        {
            n = null;
            Input();
        }
        public void Input()
        {
            Console.Write("Введите породу кошки: ");
            n = Console.ReadLine();
        }
        public override void IncomePay()
        {
            Income = H * K * 1000;
        }
        public void GetInfo()
        {
            Console.WriteLine("Кличка:{0} \nРост:{1} \nПовышающий коэффициент:{2} \nПорода кошки:{3} \nВес кошки: {4} гр", Name, H , K, n, Income);
        }
    }
}