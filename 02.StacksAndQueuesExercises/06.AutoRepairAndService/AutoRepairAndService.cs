using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.AutoRepairAndService
{
    class AutoRepairAndService
    {
        static void Main()
        {
            string[] cars = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            Queue<string> queue = new Queue<string>(cars);

            Stack<string> stack = new Stack<string>();

            var input = Console.ReadLine();

            while (input.ToLower() != "end")
            {
                if (input.ToLower().Contains("service") && queue.Count > 0)
                {
                    string car = queue.Dequeue();
                    stack.Push(car);
                    Console.WriteLine($"Vehicle {car} got served.");
                }
                else if (input.ToLower().Contains("history") && stack.Count > 0)
                {
                    Console.WriteLine(string.Join(", ", stack));
                }
                else if (input.ToLower().Contains("carinfo"))
                {
                    var tokens = input.Split('-').ToArray();
                    string car = tokens[1];
                    if (stack.Contains(car))
                    {
                        Console.WriteLine("Served.");
                    }
                    else
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                }

                input = Console.ReadLine();
            }
            if (queue.Count > 0)
            {
                Console.WriteLine($"Vehicles for service: {string.Join(", ", queue)}");
            }

            if (stack.Count > 0)
            {
                Console.WriteLine($"Served vehicles: {string.Join(", ", stack)}");
            }
        }
    }
}
