using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PrintEvenNums
{
    class PrintEvenNums
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var queue = new Queue<int>(input);
            int endIndex = queue.Count;

            var resultList = new List<int>();
            int num;
            int count = 1;
            for (int i = 0; i < endIndex; i++)
            {
                num = queue.Peek();
                if (num % 2 == 0)
                {
                    if (count == 1)
                    {
                        Console.Write($"{num}");
                    }
                    else
                    {
                        Console.Write($", {num}");
                    }
                    count++;
                }
                queue.Dequeue();
            }

            Console.WriteLine();
        }
    }
}
