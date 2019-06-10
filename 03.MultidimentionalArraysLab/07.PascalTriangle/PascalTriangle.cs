namespace _07.PascalTriangle
{
    using System;

    class PascalTriangle
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            long[][] jagArr = new long[rows][];

            for (long row = 0; row < rows; row++)
            {
                jagArr[row] = new long[row + 1];

                long[] currentRow = jagArr[row];
                currentRow[0] = 1;
                currentRow[jagArr[row].Length - 1] = 1;

                jagArr[row] = currentRow;

                for (int col = 1; col < jagArr[row].Length - 1; col++)
                {
                    if (row > 1)
                    {
                        jagArr[row][col] = jagArr[row - 1][col - 1] + jagArr[row - 1][col];
                    }
                }
            }

            foreach (long[] arr in jagArr)
            {
                Console.WriteLine(string.Join(" ", arr));
            }
        }
    }
}
