using System;
using System.Collections.Generic;

namespace Task_18_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "abc#d##c";
            Stack<char> stack = new Stack<char>();
            foreach (var c in a)
            {
                if (c == '#')
                {
                    if (stack.Count > 0)
                        stack.Pop();
                }
                else
                {
                    stack.Push(c);
                }
            }
            var array = stack.ToArray();
            Array.Reverse(array);
            string s = new string(array);
            Console.WriteLine(s);
        }
    }
}

