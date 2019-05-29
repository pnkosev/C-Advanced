using System;
using System.Collections.Generic;

namespace _07.HotPotato
{
    class HotPotato
    {
        static void Main()
        {
            var children = Console.ReadLine().Split(' ');
            var n = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>(children);

            while (queue.Count != 1)
            {
                for (int i = 1; i < n; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
