namespace _05.SquareOfMaxSum
{
    using System;
    using System.Linq;

    class SquareOfMaxSum
    {
        static void Main()
        {
            int[] size = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[size[0], size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] elements = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            int sum = int.MinValue;
            int rowIndex = 0;
            int colIndex = 0;

            for (int row = 1; row < matrix.GetLength(0); row++)
            {
                for (int col = 1; col < matrix.GetLength(1); col++)
                {
                    int currentSum = matrix[row - 1, col - 1] + matrix[row - 1, col] + matrix[row, col - 1] + matrix[row, col];
                    if (currentSum > sum)
                    {
                        sum = currentSum;
                        rowIndex = row - 1;
                        colIndex = col - 1;
                    }
                }
            }

            Console.WriteLine($"{matrix[rowIndex, colIndex]} {matrix[rowIndex, colIndex + 1]}");
            Console.WriteLine($"{matrix[rowIndex + 1, colIndex]} {matrix[rowIndex + 1, colIndex + 1]}");
            Console.WriteLine(sum);
        }
    }
}
