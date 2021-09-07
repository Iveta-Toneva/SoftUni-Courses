using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_and_Dictionaries_Advanced___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> counter = new Dictionary<double, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                double current = numbers[i];
                if (!counter.ContainsKey(current))
                {
                    counter.Add(current, 1);
                }
                else
                {
                    counter[current]++;
                }
            }
            foreach (var item in counter)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
