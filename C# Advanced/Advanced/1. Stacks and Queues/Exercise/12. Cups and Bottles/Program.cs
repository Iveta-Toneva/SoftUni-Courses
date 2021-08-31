using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Exer_12._Cups_And_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cups = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] bottles = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Stack<int> stackBottles = new Stack<int>(bottles);
            Queue<int> queueCups = new Queue<int>(cups);

            int wastedLiters = 0;

            while (stackBottles.Count > 0 && queueCups.Count > 0)
            {
                int currentCup = queueCups.Dequeue();

                while (currentCup > 0 && stackBottles.Count > 0)
                {
                    int currentBottle = stackBottles.Pop();
                    currentCup -= currentBottle;

                    if (currentCup < 0)
                    {
                        wastedLiters += Math.Abs(currentCup);
                    }
                }

            }

            if (queueCups.Count > 0)
            {
                Console.WriteLine(($"Cups: {String.Join(" ", queueCups)}"));
            }
            else
            {
                Console.WriteLine(($"Bottles: {String.Join(" ", stackBottles)}"));
            }
            Console.WriteLine($"Wasted litters of water: {wastedLiters}");


          
        }
    }
}