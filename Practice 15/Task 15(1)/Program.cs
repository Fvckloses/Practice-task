using System;

namespace Task_15_1_
{
    class MyArray<T>
    {
        public void Add(T value)
        {
            Values[index] = value;
            index++;
        }
        public void ShowValues()
        {
            for (int i=0; i < index; i++)
                Console.WriteLine(Values[i]);
        }
        public void ShowValue()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Values[a]);
        }
        protected int index = 0;
        protected T[] Values = new T[200];
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyArray<string> arr1 = new MyArray<string>();
            Console.Write("Введите количество значений: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите число: ");
                arr1.Add(Console.ReadLine());
            }
            arr1.ShowValues();
            Console.WriteLine($"Введите элемент с 0 до {n-1}");
            arr1.ShowValue();
        }
    }
}
