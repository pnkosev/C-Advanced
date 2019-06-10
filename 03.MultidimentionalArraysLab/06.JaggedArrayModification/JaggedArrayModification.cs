namespace _06.JaggedArrayModification
{
    using System;

    class JaggedArrayModification
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                string[] elements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                jaggedArray[row] = new int[elements.Length];

                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    jaggedArray[row][col] = int.Parse(elements[col]);
                }
            }

            string command = Console.ReadLine();

            while (command.ToLower() != "end")
            {
                string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = tokens[0];
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int val = int.Parse(tokens[3]);

                if (action.ToLower() == "add")
                {
                    if (row < 0 || row >= jaggedArray.Length || col < 0 || col >= jaggedArray[row].Length)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                    else
                    {
                        jaggedArray[row][col] += val;
                    }
                }
                else if (action.ToLower() == "subtract")
                {
                    if (row < 0 || row >= jaggedArray.Length || col < 0 || col >= jaggedArray[row].Length)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                    else
                    {
                        jaggedArray[row][col] -= val;
                    }
                }

                command = Console.ReadLine();
            }

            foreach (int[] arr in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", arr));
            }
        }
    }
}
