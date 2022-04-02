using System;

namespace Task_2_2_
{
    internal class Program
    {
        public class Product : Detail
        {
            int count;
            string name_product;
            public Product() : base()
            {
                this.count = 0;
                this.name_product = String.Empty;
                Input();
            }
            void Input()
            {
                Console.WriteLine("Введите название изделия");
                name_product = Console.ReadLine();
                Console.WriteLine("Введите количество механизмов в изделии");
                count = Convert.ToInt32(Console.ReadLine());
            }
            public override string Vivod()
            {
                return base.Vivod() + "\n" +
                    " Название изделия - " + name_product + "\n" +
                    " Количество механизмов в изделии - "+count+" ";
            }
        }
        static void Main(string[] args)
        {
            Detail product = new Product();
            product.Vvod();
            Console.WriteLine(product.Vivod());
        }
    }
    public class Knot : Detail
    {
        string name_knot;
        public Knot() : base()
        {
            this.name_knot = String.Empty;
            Input();
        }
        void Input()
        {
            Console.WriteLine("Введите название узла ");
            name_knot = Console.ReadLine();
        }
        public override string Vivod()
        {
            return base.Vivod() + " Название узла - " + name_knot + " ";
        }

    }
    public class Mechanism : Detail
    {
        string name_mechanism;
        public Mechanism() : base()
        {
            this.name_mechanism = String.Empty;
            Input();
        }
        void Input()
        {
            Console.WriteLine("Введите название механизма");
            name_mechanism = Console.ReadLine();
        }
        public override string Vivod()
        {
            return base.Vivod() + " Название механизма - " + name_mechanism + " ";
        }
    }
    public class Detail
    {
        string name_detail, material;
        int number;
        public Detail()
        {
            this.name_detail = String.Empty;
            this.number = 0;
            this.material = String.Empty;
            //Vvod();
        }
        public void Vvod()
        {
            Console.WriteLine("Введите название детали");
            name_detail = Console.ReadLine();
            Console.WriteLine("Введите номер детали");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите материал детали");
            material = Console.ReadLine();
        }
        public virtual string Vivod()
        {
            return "Название детали - " + name_detail + "\n" +
                "Номер детали - " + number + "\n" +
                "Материал детали -" + material+" ";
        }
    }
}

