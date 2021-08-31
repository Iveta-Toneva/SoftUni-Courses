using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Exer_11.__Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceOfBullet = int.Parse(Console.ReadLine());
            int sizeOfGunBarrel = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> locks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            int value = int.Parse(Console.ReadLine());

            int countOfBullets = 0;
            int countGunBarrel = 0;


            while (bullets.Count > 0 && locks.Count > 0)
            {
                int currentBullet = bullets.Peek();
                int currentLock = locks.Peek();

                if (currentBullet <= currentLock)
                {
                    bullets.Pop();
                    locks.Dequeue();
                    Console.WriteLine("Bang!");
                    countOfBullets++;
                    countGunBarrel++;
                }
                else
                {
                    bullets.Pop();
                    Console.WriteLine("Ping!");
                    countOfBullets++;
                    countGunBarrel++;
                }

                if (countGunBarrel == sizeOfGunBarrel && bullets.Count > 0)
                {
                    countGunBarrel = 0;
                    Console.WriteLine("Reloading!");
                }
            }

            if (locks.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {
                int moneyEarned = value - countOfBullets * priceOfBullet;
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
            }
        }
    }
}