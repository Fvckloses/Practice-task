using System;

namespace Task_19_2_
{
    class Program
    {
        public delegate double CalcFigure(double R);
        /// <summary>
        /// Расчёт длины окружности
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        static double Get_Length(double r)
        {
            double D;
            D = 2 * Math.PI * r;
            Console.WriteLine($"Длина окружности = { Math.Round(D, 3) }");
            return D;
        }
        /// <summary>
        /// Расчёт площади круга
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        static double Get_Area(double r)
        {
            double S;
            S = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"Площадь круга = { Math.Round(S, 3) }");
            return S;
        }
        /// <summary>
        /// Расчёт объёма шара
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        static double Get_Volume(double r)
        {
            double V;
            V = 4 / 3 * Math.PI * Math.Pow(r, 3);
            Console.WriteLine($"Объём шара = { Math.Round(V, 3) }");
            return V;
        }
        /// <summary>
        /// Ввод радиуса
        /// </summary>
        /// <param name="a"></param>
        public static void Zadan2(CalcFigure a)
        {
            Console.Write("Введите радиус-");
            double rd = Convert.ToDouble(Console.ReadLine());
            a(rd);
        }
        /// <summary>
        /// Ввод радиуса
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Введите радиус-");
            double rad = Convert.ToDouble(Console.ReadLine());
            CalcFigure CF = new CalcFigure(Get_Length);
            CF += Get_Area;
            CF += Get_Volume;
            // if (CF != null)
            CF(rad);
            Zadan2(CF);
            Console.ReadLine();
        }
    }
}
