namespace _01.CountSameValues
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CountSameValues
    {
        static void Main()
        {
            double[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> counter = new Dictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {
                double currentNum = input[i];

                if (!counter.ContainsKey(currentNum))
                {
                    counter[currentNum] = 0;
                }

                counter[currentNum]++;
            }

            foreach (var pair in counter)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value} times");
            }
        }
    }
}
