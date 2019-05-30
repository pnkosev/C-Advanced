namespace _10.Crossroads
{
using System;
    using System.Collections.Generic;

    class Crossroads
    {
        static void Main()
        {
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            Queue<string> carQueue = new Queue<string>();
            int count = 0;
            bool isSafelyPassed = true;
            char hitChar = ' ';

            while (input.ToLower() != "end")
            {
                if (input.ToLower() != "green")
                {
                    carQueue.Enqueue(input);
                }
                else
                {
                    int timeToPass = greenLightDuration;
                    while (timeToPass != 0 && carQueue.Count != 0)
                    {
                        int carLength = carQueue.Peek().Length;
                        if (timeToPass - carLength >= 0)
                        {
                            carQueue.Dequeue();
                            count++;
                            timeToPass -= carLength;
                        }
                        else if (timeToPass - carLength < 0)
                        {
                            carLength -= timeToPass;

                            if (freeWindowDuration < carLength)
                            {
                                isSafelyPassed = false;
                                carLength -= freeWindowDuration;
                                string car = carQueue.Peek();
                                int passedChars = car.Length - carLength;
                                car = car.Remove(0, passedChars);
                                hitChar = car[0];
                            }
                            else
                            {
                                carQueue.Dequeue();
                                count++;
                            }
                            break;
                        }
                    }
                }
                if (!isSafelyPassed)
                {
                    break;
                }
                input = Console.ReadLine();
            }

            if (isSafelyPassed)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{count} total cars passed the crossroads.");
            }
            else
            {
                Console.WriteLine("A crash happened!");
                Console.WriteLine($"{carQueue.Peek()} was hit at {hitChar}.");
            }
        }
    }
}
