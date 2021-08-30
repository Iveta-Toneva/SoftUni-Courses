using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Queue<string> queue = new Queue<string>();
            for (int i = 0; i < songs.Length; i++)
            {
                queue.Enqueue(songs[i]);
            }
            string command = Console.ReadLine();
            while (queue.Count>0)
            {
                if (command.Contains("Play"))
                {
                    queue.Dequeue();
                }
                else if (command.Contains("Add"))
                {
                    string[] splitted = command.Split("Add ");
                    string song = splitted[1];
                    if (queue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(song);
                    }

                }
                else if (command.Contains("Show"))
                {
                    Console.WriteLine(string.Join(", ",queue));
                }



                command = Console.ReadLine();
            }
            Console.WriteLine("No more songs!");

        }
    }
}
