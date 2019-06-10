namespace _03.PrimaryDiagonalSum
{
    using System;
    using System.Linq;

    class PrimaryDiagonalSum
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            int primeDiagonalSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] elements = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                    
                    if (row == col)
                    {
                        primeDiagonalSum += matrix[row, col];
                    }
                }
            }

            Console.WriteLine(primeDiagonalSum);
        }
    }
}
