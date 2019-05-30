namespace _11.KeyRevolver
{
using System;
    using System.Collections.Generic;
    using System.Linq;

    public class KeyRevolver
    {
        static void Main()
        {
            int pricePerBullet = int.Parse(Console.ReadLine());
            int barrel = int.Parse(Console.ReadLine());
            int[] bulletsInput = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            int[] locksInput = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            int prize = int.Parse(Console.ReadLine());

            Stack<int> bullets = new Stack<int>(bulletsInput);
            Queue<int> locks = new Queue<int>(locksInput);

            int currentBarrel = barrel;
            int bulletsUsed = 0;

            while (bullets.Count > 0 && locks.Count > 0)
            {
                int bullet = bullets.Pop();
                currentBarrel--;
                bulletsUsed++;
                int currentLock = locks.Peek();

                if (bullet <= currentLock)
                {
                    locks.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                if (currentBarrel == 0)
                {
                    if (bullets.Count > 0)
                    {
                        Console.WriteLine("Reloading!");
                        currentBarrel = Math.Min(barrel, bullets.Count);
                    }
                }
            }

            if (locks.Count == 0)
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${prize - (bulletsUsed * pricePerBullet)}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
