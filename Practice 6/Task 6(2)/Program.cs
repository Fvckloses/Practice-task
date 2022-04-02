using System;

namespace Task_6_2_
{
    internal class Program
    {
        static void Main()
        {
            string str7 = "На 3 минуте матча был забит гол игроком под номером 7, это его 4 гол в карьере.";
            Console.WriteLine(str7);
            int sum = 0;
            foreach (char ch in str7)
            {
                if (int.TryParse(ch.ToString(), out int digit))
                    sum += digit;
            }
            Console.WriteLine($"Сумма = {sum}");
        }
    }
}
