using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class FashionBoutique
    {
        static void Main()
        {
            int[] clothesPrices = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>(clothesPrices);

            int capacity = int.Parse(Console.ReadLine());
            int curCapacity = capacity;

            int racks = 1;

            while (stack.Count > 0)
            {
                if (curCapacity - stack.Peek() >= 0)
                {
                    curCapacity -= stack.Pop();
                }
                else
                {
                    racks++;
                    curCapacity = capacity;
                }
            }
            Console.WriteLine(racks);
        }
    }
}
