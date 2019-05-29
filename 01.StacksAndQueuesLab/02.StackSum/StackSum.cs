using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.StackSum
{
    class StackSum
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>(input);

            var commandInfo = Console.ReadLine().ToLower();

            while (commandInfo != "end")
            {
                var tokens = commandInfo.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var command = tokens[0].ToLower();

                if (command == "add")
                {
                    for (int i = 1; i < tokens.Length; i++)
                    {
                        stack.Push(int.Parse(tokens[i]));
                    }
                }
                else if (command == "remove")
                {
                    var itemsToRemove = int.Parse(tokens[1]);

                    if (stack.Count >= itemsToRemove)
                    {
                        for (int i = 0; i < itemsToRemove; i++)
                        {
                            stack.Pop();
                        }
                    }
                }

                commandInfo = Console.ReadLine().ToLower();
            }

            var sum = stack.Sum();

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
