using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaxMinElements
{
    class MaxMinElements
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            while (n > 0)
            {
                var line = Console.ReadLine();
                if (line[0] == '1')
                {
                    var tokens = line.Split(' ');
                    int num = int.Parse(tokens[1]);

                    stack.Push(num);
                }
                else if (line[0] == '2')
                {
                    stack.TryPop(out int result);
                }
                else if (line[0] == '3')
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                }
                else if (line[0] == '4')
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
                n--;
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
