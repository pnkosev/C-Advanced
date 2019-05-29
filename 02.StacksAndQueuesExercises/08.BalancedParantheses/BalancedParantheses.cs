namespace _08.BalancedParantheses
{
using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BalancedParantheses
    {
        static void Main()
        {
            Stack<char> stackOfParatheses = new Stack<char>();
            char[] input = Console.ReadLine()
                .ToCharArray();

            char[] openingParantheses = { '(', '{', '[' };

            bool isBalanced = true;

            for (int i = 0; i < input.Length; i++)
            {
                char currentParantheses = input[i];
                
                if (openingParantheses.Contains(currentParantheses))
                {
                    stackOfParatheses.Push(currentParantheses);
                }
                else
                {
                    if (stackOfParatheses.Any() &&
                        ((stackOfParatheses.Peek() == '(' && currentParantheses == ')') ||
                        (stackOfParatheses.Peek() == '{' && currentParantheses == '}') ||
                        (stackOfParatheses.Peek() == '[' && currentParantheses == ']')))
                    {
                        stackOfParatheses.Pop();
                    }
                    else
                    {
                        isBalanced = false;
                        break;
                    }
                }
            }
            Console.WriteLine(isBalanced ? "YES" : "NO");
        }
    }
}
