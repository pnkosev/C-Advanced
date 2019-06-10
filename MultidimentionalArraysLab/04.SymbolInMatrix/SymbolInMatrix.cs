namespace _04.SymbolInMatrix
{
    using System;

    class SymbolInMatrix
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            int n = 0;

            while (n < size)
            {
                char[] elements = Console.ReadLine().ToCharArray();
                
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[n, col] = elements[col];
                }

                n++;
            }

            char searchedChar = char.Parse(Console.ReadLine());
            bool found = false;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == searchedChar)
                    {
                        Console.WriteLine($"({row}, {col})");
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine($"{searchedChar} does not occur in the matrix");
            }
        }
    }
}
