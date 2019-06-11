namespace _04.MatrixShuffling
{
    using System;
    using System.Linq;

    class MatrixShuffling
    {
        static void Main()
        {
            int[] size = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string[,] matrix = new string[size[0], size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] elements = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            string command = Console.ReadLine();

            while (command.ToLower() != "end")
            {
                if (!command.ToLower().StartsWith("swap"))
                {
                    Console.WriteLine("Invalid input!");
                    command = Console.ReadLine();
                    continue;
                }

                string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    command = Console.ReadLine();
                    continue;
                }

                int row1 = int.Parse(tokens[1]);
                int col1 = int.Parse(tokens[2]);
                int row2 = int.Parse(tokens[3]);
                int col2 = int.Parse(tokens[4]);

                if (row1 < 0 || row2 > matrix.GetLength(0) || col1 < 0 || col2 > matrix.GetLength(1))
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    string num1 = matrix[row1, col1];
                    string num2 = matrix[row2, col2];

                    matrix[row1, col1] = num2;
                    matrix[row2, col2] = num1;

                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            Console.Write($"{matrix[row, col]} ");
                        }

                        Console.WriteLine();
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}
