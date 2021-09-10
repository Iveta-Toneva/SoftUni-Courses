using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(" -> ").ToArray();
                string colour = data[0];
                string[] clothes = data[1].Split(",").ToArray();
                if (!dict.ContainsKey(colour))
                {
                    dict.Add(colour, new Dictionary<string, int>());
                }
                for (int j = 0; j < clothes.Length; j++)
                {
                    string current = clothes[j];
                    if (!dict[colour].ContainsKey(current))
                    {
                        dict[colour].Add(current, 1);
                    }
                    else
                    {
                        dict[colour][current]++;
                    }
                }

            }
            string[] search = Console.ReadLine().Split().ToArray();
            string searchColour = search[0];
            string searchCloth = search[1];
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var cloth in item.Value)
                {
                    if (searchColour==item.Key&& searchCloth==cloth.Key)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                    
                }
            }
        }
    }
}
