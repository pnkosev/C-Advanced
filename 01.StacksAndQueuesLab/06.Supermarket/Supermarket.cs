using System;
using System.Collections.Generic;

namespace _06.Supermarket
{
    class Supermarket
    {
        static void Main()
        {
            var input = Console.ReadLine();
            Queue<string> queue = new Queue<string>();

            while (input.ToLower() != "end")
            {
                if (input.ToLower() != "paid")
                {
                    queue.Enqueue(input);
                }
                else
                {
                    int count = queue.Count;
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
