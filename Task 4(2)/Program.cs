using System;

namespace Task_4_2_
{
    internal class Program
    {
        static double F(double x)
        {
            if ((x > -3) & (x < 3)) { return (2 / x); }
            else if (x <= -3) { return (5 * x); }
            else { throw new IndexOutOfRangeException("Ошибка: выход за диапазон значения X."); }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите х, где -3<x<3 или x<=-3:");
                var x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("F(x)= " + F(x));

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message, ex.StackTrace);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message, ex.StackTrace);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
