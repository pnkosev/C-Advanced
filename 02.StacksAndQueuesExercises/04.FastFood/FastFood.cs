using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    class FastFood
    {
        static void Main()
        {
            int totalFood = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Queue<int> queue = new Queue<int>(orders);
            Console.WriteLine(queue.Max());

            while (queue.Count > 0)
            {
                if (totalFood >= queue.Peek() && totalFood > 0)
                {
                    int currentOrder = queue.Dequeue();
                    totalFood -= currentOrder;
                }
                else
                {
                    break;
                }
            }

            if (queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queue.ToArray())}");
            }
        }
    }
}
