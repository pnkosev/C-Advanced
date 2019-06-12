namespace _07.KnightGame
{
    using System;

    class KnightGame
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string elements = Console.ReadLine();
                
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            int totalThreads = 0;
            int[] biggestThreadCoords = new int[2];
            int totalDeletions = 0;

            do
            {
                int biggestThread = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        int currentAttacker = 0;

                        if (matrix[row, col] == 'K')
                        {
                            if (row - 1 >= 0 && col - 2 >= 0 && matrix[row - 1, col - 2] == 'K')
                            {
                                totalThreads++;
                                currentAttacker++;
                            }

                            if (row - 2 >= 0 && col - 1 >= 0 && matrix[row - 2, col - 1] == 'K')
                            {
                                totalThreads++;
                                currentAttacker++;
                            }

                            if (row - 2 >= 0 && col + 1 < matrix.GetLength(1) && matrix[row - 2, col + 1] == 'K')
                            {
                                totalThreads++;
                                currentAttacker++;
                            }

                            if (row - 1 >= 0 && col + 2 < matrix.GetLength(1) && matrix[row - 1, col + 2] == 'K')
                            {
                                totalThreads++;
                                currentAttacker++;
                            }

                            if (row + 1 < matrix.GetLength(0) && col + 2 < matrix.GetLength(1) && matrix[row + 1, col + 2] == 'K')
                            {
                                totalThreads++;
                                currentAttacker++;
                            }

                            if (row + 2 < matrix.GetLength(0) && col + 1 < matrix.GetLength(1) && matrix[row + 2, col + 1] == 'K')
                            {
                                totalThreads++;
                                currentAttacker++;
                            }

                            if (row + 2 < matrix.GetLength(0) && col - 1 >= 0 && matrix[row + 2, col - 1] == 'K')
                            {
                                totalThreads++;
                                currentAttacker++;
                            }

                            if (row + 1 < matrix.GetLength(0) && col - 2 >= 0 && matrix[row + 1, col - 2] == 'K')
                            {
                                totalThreads++;
                                currentAttacker++;
                            }

                            if (currentAttacker > biggestThread)
                            {
                                biggestThread = currentAttacker;
                                biggestThreadCoords[0] = row;
                                biggestThreadCoords[1] = col;
                            }
                        }
                    }
                }

                if (totalThreads > 0 && biggestThread != 0)
                {
                    int targetRow = biggestThreadCoords[0];
                    int targetCol = biggestThreadCoords[1];

                    matrix[targetRow, targetCol] = '0';

                    totalDeletions++;
                    totalThreads -= biggestThread;
                }
                else
                {
                    totalThreads = 0;
                }

            } while (totalThreads > 0);

            Console.WriteLine(totalDeletions);
        }
    }
}
