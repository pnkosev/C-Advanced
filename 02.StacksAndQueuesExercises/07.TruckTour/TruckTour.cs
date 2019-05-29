using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TruckTour
{
    class TruckTour
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Queue<long[]> queue = new Queue<long[]>();

            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToArray());

            }

            int index = 0;

            while (true)
            {
                long fuel = 0;

                foreach (var item in queue)
                {
                    long fuelAmount = item[0];
                    long distance = item[1];

                    fuel += fuelAmount - distance;

                    if (fuel < 0)
                    {
                        queue.Enqueue(queue.Dequeue());
                        index++;
                        break;
                    }
                }
                if (fuel >= 0)
                {
                    break;
                }
            }

            Console.WriteLine(index);
        }
    }
}