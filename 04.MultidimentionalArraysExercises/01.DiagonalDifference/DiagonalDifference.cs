namespace _01.DiagonalDifference
{
    using System;
    using System.Linq;

    class DiagonalDifference
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

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

            int primaryDiagonalSum = int.MinValue;
            int secondaryDiagonalSum = int.MinValue;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                primaryDiagonalSum += matrix[i, i];
                secondaryDiagonalSum += matrix[i, matrix.GetLength(0) - 1 - i];
            }

            Console.WriteLine(Math.Abs(primaryDiagonalSum - secondaryDiagonalSum));
        }
    }
}
