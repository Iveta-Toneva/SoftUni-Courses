using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, SortedSet<string>>> vloggers = new Dictionary<string, Dictionary<string, SortedSet<string>>>();

            string[] input = Console.ReadLine().Split(' ');

            while (input[0] != "Statistics")
            {
                string vlogger = input[0];
                string command = input[1];
                string follower = input[2];

                if (command == "joined")
                {
                    if (!vloggers.ContainsKey(vlogger))
                    {
                        vloggers.Add(vlogger, new Dictionary<string, SortedSet<string>>());
                        vloggers[vlogger].Add("followers", new SortedSet<string>());
                        vloggers[vlogger].Add("following", new SortedSet<string>());
                    }
                }
                else if (command == "followed")
                {
                    if (follower != vlogger && vloggers.ContainsKey(vlogger) && vloggers.ContainsKey(follower))
                    {
                        vloggers[vlogger]["following"].Add(follower);
                        vloggers[follower]["followers"].Add(vlogger);
                    }
                }

                input = Console.ReadLine().Split(' ');
            }
            int count = 1;

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

            foreach (var vlogger in vloggers.OrderByDescending(v => v.Value["followers"].Count).ThenBy(v => v.Value["following"].Count))
            {
                Console.WriteLine($"{count}. {vlogger.Key} : {vlogger.Value["followers"].Count} followers, {vlogger.Value["following"].Count} following");

                if (count == 1)
                {
                    Console.WriteLine("*  " + String.Join(Environment.NewLine + "*  ", vlogger.Value["followers"]));
                }

                count++;
            }

        } 
        
    }
}
