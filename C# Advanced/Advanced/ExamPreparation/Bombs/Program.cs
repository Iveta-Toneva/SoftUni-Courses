using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dataeffects= Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[] datacasings = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Queue<int> effects = new Queue<int>(dataeffects);
            Stack<int> casings = new Stack<int>(datacasings);
            int decrease = 0;
            int datura = 0;
            int cherry = 0;
            int smoke = 0;
            while (effects.Count>0&&casings.Count>0)
            {
                int currenEffect = effects.Peek();
                int currentCasing = casings.Peek()-decrease;
                int result = currenEffect + currentCasing;
                if (result==40)
                {
                    datura++;
                    effects.Dequeue();
                    casings.Pop();
                    decrease = 0;
                }
                else if (result==60)
                {
                    cherry++;
                    effects.Dequeue();
                    casings.Pop();

                    decrease = 0;
                }
                else if (result==120)
                {
                    smoke++;
                    effects.Dequeue();
                    casings.Pop();
                    decrease = 0;
                }
                else
                {
                    decrease +=5;
                }
                if (currentCasing<0)
                {
                    break;
                }
                if (datura >= 3 && smoke >= 3 && cherry >= 3)
                {
                    break;
                }
                

            }
            if (datura>=3&&smoke>=3&&cherry>=3)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
                
            }
            if (effects.Count==0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", effects)}");
            }
            if (casings.Count == 0)
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", casings)}");
            }
            Console.WriteLine($"Cherry Bombs: {cherry}");
            Console.WriteLine($"Datura Bombs: {datura}");
            Console.WriteLine($"Smoke Decoy Bombs: {smoke}");
        }
    }
}
