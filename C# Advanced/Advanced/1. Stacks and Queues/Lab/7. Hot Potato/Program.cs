using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            Queue<string> hotPotato = new Queue<string>();
            for (int i = 0; i < kids.Length; i++)
            {
                hotPotato.Enqueue(kids[i]);
            }
            while (hotPotato.Count>1)
            {
                string kid = hotPotato.Dequeue();
                count++;
                if (count==n)
                {
                    count = 0;
                    Console.WriteLine($"Removed {kid}");
                }
                else
                {
                    hotPotato.Enqueue(kid);
                }
            }
            Console.WriteLine($"Last is {hotPotato.Dequeue()}");
        }
    }
}
