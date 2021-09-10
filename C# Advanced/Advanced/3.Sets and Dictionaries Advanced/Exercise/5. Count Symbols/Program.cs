using System;
using System.Collections.Generic;

namespace _5._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<char, int> dict = new SortedDictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                char current = input[i];
                if (!dict.ContainsKey(current))
                {
                    dict.Add(current, 1);
                }
                else
                {
                    dict[current]++;
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
