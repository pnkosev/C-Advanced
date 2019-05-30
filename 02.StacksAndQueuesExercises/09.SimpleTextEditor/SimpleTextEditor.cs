
namespace _09.SimpleTextEditor
{
using System;
    using System.Collections.Generic;

    class SimpleTextEditor
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string text = "";
            Stack<string> prevState = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "1")
                {
                    prevState.Push(text);
                    text += input[1];
                }
                else if (input[0] == "2")
                {
                    prevState.Push(text);
                    int count = int.Parse(input[1]);
                    int startIndex = Math.Max(0, text.Length - count);
                    text = text.Remove(startIndex, count);
                }
                else if (input[0] == "3")
                {
                    int index = int.Parse(input[1]);
                    Console.WriteLine(text[index - 1]);
                }
                else if (input[0] == "4")
                {
                    text = prevState.Pop();
                }
            }
        }
    }
}
