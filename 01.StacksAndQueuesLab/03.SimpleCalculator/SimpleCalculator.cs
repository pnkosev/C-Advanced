using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SimpleCalculator
{
    class SimpleCalculator
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var values = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Stack<string> stack = new Stack<string>(values.Reverse());

            while (stack.Count > 1)
            {
                int first = int.Parse(stack.Pop());
                string opertator = stack.Pop();
                int second = int.Parse(stack.Pop());

                switch (opertator)
                {
                    case "+":
                        stack.Push((first + second).ToString());
                        break;
                    case "-":
                        stack.Push((first - second).ToString());
                        break;
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
