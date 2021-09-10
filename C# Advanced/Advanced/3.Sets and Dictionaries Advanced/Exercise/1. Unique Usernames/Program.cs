using System;
using System.Collections.Generic;

namespace Sets_and_Dictionaries_Advanced___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> usernames = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                usernames.Add(name);
            }
            Console.WriteLine(string.Join(Environment.NewLine,usernames));
        }
    }
}
