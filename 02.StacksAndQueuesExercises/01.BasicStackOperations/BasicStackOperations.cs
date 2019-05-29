using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BasicStackOperations
{
    class BasicStackOperations
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int numsToPush = input[0];
            int numsToPop = input[1];
            int searchedNum = input[2];

            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < Math.Min(arr.Length, numsToPush); i++)
            {
                stack.Push(arr[i]);
            }

            int count = stack.Count;

            for (int i = 0; i < Math.Min(count, numsToPop); i++)
            {
                stack.Pop();
            }

            if (stack.Contains(searchedNum))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count != 0)
            {
                Console.WriteLine(stack.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
