using System;

namespace Task_15_2_
{
    class MyDictionary<Tkey, Tvalue>
    {
        public void Add(Tkey value1, Tkey value2)
        {
            Values[index, index1] = value1;
            index++;
            index1++;
        }
        public void ShowValues()
        {
            for (int i = 0; i < index; i++)
            {
                for (int j = 0; j < 2; j++)
                { 
                    Console.Write(Values[i, j]);
                }
                Console.WriteLine();
            }     
        }
        public void ShowValue()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Values[a,b]);
        }
        protected int index = 0;
        protected int index1 = 0;
        protected Tkey[,] Values = new Tkey[200,200];
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<double, double> arr1 = new MyDictionary<double, double>();
            Console.Write("Введите количество значений: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int a, b;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите числа: ");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                arr1.Add(a, b);
            }
            arr1.ShowValues();
            Console.WriteLine("Введите координаты: ");
            arr1.ShowValue();
            Console.ReadLine();
        }
    }
}
