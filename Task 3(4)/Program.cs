using System;

namespace Task_3_4_
{
    internal class Program
    {
        class Matrix
        {
            public int n;
            public int m;
            public void Func(double[,] a, int b)
            {
                double[,] c = new double[n, m];
                Console.WriteLine("Ваша матрица");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                        Console.Write("{0}{1}", a[i, j], "\t");

                    Console.WriteLine();
                }
                Console.WriteLine("Исходная матрица");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        c[i, j] = a[i, j] - a[b, j];
                    }
                }

                for (int j = 0; j < m; j++)
                {
                    c[b, j] = c[b, j] + a[b, j];
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                        Console.Write("{0}{1}", c[i, j], "\t");

                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Введите размер матрицы");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            Matrix matrix = new Matrix();
            double[,] a = new double[n, m];
            matrix.m = m;
            matrix.n = n;
            Console.WriteLine("Введите элементы матрицы");
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    a[i, j] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите строку");
            int b = Convert.ToInt32(Console.ReadLine());
            matrix.Func(a, b);
            Console.ReadLine();
        }
    }
}
