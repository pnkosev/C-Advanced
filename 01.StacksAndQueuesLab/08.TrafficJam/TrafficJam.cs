using System;
using System.Collections.Generic;

namespace _08.TrafficJam
{
    class TrafficJam
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var line = Console.ReadLine();
            Queue<string> queue = new Queue<string>();
            int totalCarsPassed = 0;

            while (line.ToLower() != "end")
            {
                if (line.ToLower() != "green")
                {
                    queue.Enqueue(line);
                }
                else
                {
                    int carsCount = queue.Count;
                    for (int i = 0; i < Math.Min(n, carsCount); i++)
                    {
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        totalCarsPassed++;
                    }
                }
                line = Console.ReadLine();
            }
            Console.WriteLine($"{totalCarsPassed} cars passed the crossroads.");
        }
    }
}
