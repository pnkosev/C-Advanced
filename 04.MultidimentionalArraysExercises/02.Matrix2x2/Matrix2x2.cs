namespace _02.Matrix2x2
{
    using System;
    using System.Linq;

    class Matrix2x2
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            char[,] matrix = new char[size[0], size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] elements = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            int count = 0;

            for (int row = 1; row < matrix.GetLength(0); row++)
            {
                for (int col = 1; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row - 1, col - 1] == matrix[row - 1, col] &&
                        matrix[row, col - 1] == matrix[row, col] &&
                        matrix[row - 1, col - 1] == matrix[row, col - 1])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
