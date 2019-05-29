using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicQueueOperations
{
    class BasicQueueOperations
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int numsToPush = input[0];
            int numsToPop = input[1];
            int searchedNum = input[2];

            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < Math.Min(arr.Length, numsToPush); i++)
            {
                queue.Enqueue(arr[i]);
            }

            int count = queue.Count;

            for (int i = 0; i < Math.Min(count, numsToPop); i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(searchedNum))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count != 0)
            {
                Console.WriteLine(queue.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
