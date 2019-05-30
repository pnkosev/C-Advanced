namespace _12.CupsAndBottles
{
using System;
    using System.Collections.Generic;
    using System.Linq;

    class CupsAndBottles
    {
        static void Main()
        {
            int[] cupsArray = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            int[] bottlesArray = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            Queue<int> queueOfCups = new Queue<int>(cupsArray);
            Stack<int> stackOfBottles = new Stack<int>(bottlesArray);

            int wastedWater = 0;

            while (queueOfCups.Count > 0 && stackOfBottles.Count > 0)
            {
                int currentBottle = stackOfBottles.Pop();
                int currentCup = queueOfCups.Peek();
                                
                if (currentBottle >= currentCup)
                {
                    queueOfCups.Dequeue();
                    wastedWater += currentBottle - currentCup;
                }
                else
                {
                    while (currentCup > 0)
                    {
                        currentCup -= currentBottle;
                        if (currentCup <= 0)
                        {
                            wastedWater += Math.Abs(currentCup);
                            queueOfCups.Dequeue();
                            break;
                        }
                        currentBottle = stackOfBottles.Pop();
                    }
                }
            }

            if (queueOfCups.Count == 0)
            {
                Console.WriteLine($"Bottles: {string.Join(' ', stackOfBottles)}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(' ', queueOfCups)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
