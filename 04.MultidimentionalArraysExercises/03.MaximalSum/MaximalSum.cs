namespace _03.MaximalSum
{
    using System;
    using System.Linq;

    class MaximalSum
    {
        static void Main()
        {
            int[] size = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[size[0], size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] elements = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            int sum = int.MinValue;
            int startRowIndex = -1;
            int startColIndex = -1;

            for (int row = 2; row < matrix.GetLength(0); row++)
            {

                for (int col = 2; col < matrix.GetLength(1); col++)
                {
                    int currentSum = 0;
                    currentSum +=
                        matrix[row - 2, col - 2] + matrix[row - 2, col - 1] + matrix[row - 2, col] +
                        matrix[row - 1, col - 2] + matrix[row - 1, col - 1] + matrix[row - 1, col] +
                        matrix[row, col - 2] + matrix[row, col - 1] + matrix[row, col];

                    if (currentSum > sum)
                    {
                        sum = currentSum;
                        startRowIndex = row - 2;
                        startColIndex = col - 2;
                    }
                }
            }

            if (startRowIndex > -1)
            {
                Console.WriteLine($"Sum = {sum}");
                Console.WriteLine($"{matrix[startRowIndex, startColIndex]} {matrix[startRowIndex, startColIndex + 1]} {matrix[startRowIndex, startColIndex + 2]}");
                Console.WriteLine($"{matrix[startRowIndex + 1, startColIndex]} {matrix[startRowIndex + 1, startColIndex + 1]} {matrix[startRowIndex + 1, startColIndex + 2]}");
                Console.WriteLine($"{matrix[startRowIndex + 2, startColIndex]} {matrix[startRowIndex + 2, startColIndex + 1]} {matrix[startRowIndex + 2, startColIndex + 2]}");
            }
        }
    }
}
