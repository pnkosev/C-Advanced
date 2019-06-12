namespace _06.BombTheBasement
{
    using System;
    using System.Linq;

    class BombTheBasement
    {
        static void Main()
        {
            int[] size = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[size[0], size[1]];

            int[] tokens = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int targetRow = tokens[0];
            int targetCol = tokens[1];
            int radius = tokens[2];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    bool isInRange = Math.Pow(row - targetRow, 2) + Math.Pow(col - targetCol, 2) <= Math.Pow(radius, 2);

                    if (isInRange)
                    {
                        matrix[row, col] = 1;
                    }
                }
            }

            for (int col1 = 0; col1 < matrix.GetLength(1); col1++)
            {
                int counter = 0;

                for (int row1 = 0; row1 < matrix.GetLength(0); row1++)
                {
                    if (matrix[row1, col1] == 1)
                    {
                        counter++;
                        matrix[row1, col1] = 0;
                    }
                }

                if (counter > 0)
                {
                    for (int row1 = 0; row1 < counter; row1++)
                    {
                        matrix[row1, col1] = 1;
                    }
                }
            }

            // SOLUTION 2

            //int colCounter = 0;

            //while (colCounter < matrix.GetLength(1))
            //{
            //    int[] column = new int[matrix.GetLength(1)];

            //    for (int row = 0; row < matrix.GetLength(0); row++)
            //    {
            //        column[row] = matrix[row, colCounter];
            //    }

            //    if (column.Contains(1))
            //    {
            //        int[] sorted = column.OrderByDescending(n => n).ToArray();

            //        for (int row = 0; row < matrix.GetLength(0); row++)
            //        {
            //            matrix[row, colCounter] = sorted[row];
            //        }
            //    }

            //    colCounter++;
            //}
            // -------------------


            // SOLUTION 3

            //for (int col = 0; col < matrix.GetLength(1); col++)
            //{
            //    int[] column = new int[matrix.GetLength(1)];

            //    for (int row = 0; row < matrix.GetLength(0); row++)
            //    {
            //        column[row] = matrix[row, col];
            //    }

            //    if (column.Contains(1))
            //    {
            //        int[] sorted = column.OrderByDescending(n => n).ToArray();

            //        for (int col1 = col; col1 < matrix.GetLength(1); col1++)
            //        {
            //            for (int row1 = 0; row1 < matrix.GetLength(0); row1++)
            //            {
            //                matrix[row1, col1] = sorted[row1];
            //            }
            //            break;
            //        }
            //    }
            //}

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }

                Console.WriteLine();
            }
        }
    }
}