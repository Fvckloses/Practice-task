using System;

namespace Library17
{
    public abstract class Figures
    {
        public abstract void Sr();
        public abstract void ravn();
        public class Triangle : Figures
        {
            public Triangle(int side1, int side2, int side3)
            {
                this.Side1 = side1;
                this.Side2 = side2;
                this.Side3 = side3;
                this.P = side1 + side2 + side3;
            }
            public int Side1;
            public int Side2;
            public int Side3;
            public int P;
            public override void Sr()
            {
                if (P > 0)
                {
                    Console.WriteLine("Периметр треугольника: {0}", P);
                }
                else
                {
                    Console.WriteLine("Стороны треугольника меньше либо равны нулю");
                }
            }
            public override void ravn()
            {
                if (Math.Pow(Side1,2) + Math.Pow(Side2, 2) == Math.Pow(Side3, 2))
                {
                    Console.WriteLine("Треугольник прямоугольный");
                }
                else if (Math.Pow(Side1, 2) + Math.Pow(Side2, 2) < Math.Pow(Side3, 2))
                {
                    Console.WriteLine("Треугольник остроугольный");
                }
                else if (Math.Pow(Side1, 2) + Math.Pow(Side2, 2) > Math.Pow(Side3, 2))
                {
                    Console.WriteLine("Треугольник тупоугольный");
                }
            }
        }
        public class Rectangle : Figures
        {
            public Rectangle(int side1, int side2)
            {
                this.Side1 = side1;
                this.Side2 = side2;
                this.P = (side1 + side2) * 2;
                this.S = side1 * side2;
            }
            public int Side1;
            public int Side2;
            public int P;
            public int S;
            public override void Sr()
            {
                if (P > 0)
                {
                    Console.WriteLine("Периметр прямоугольника: {0}", P);
                }
                else
                {
                    Console.WriteLine("Стороны прямоугольника меньше либо равны нулю");
                }
            }
            public override void ravn()
            {
                if (S > 0)
                {
                    Console.WriteLine("Площадь прямоугольника: {0}", S);
                }
                else
                {
                    Console.WriteLine("Стороны прямоугольника меньше либо равны нулю");
                }
            }
        }
    }
}
