using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int> first = new HashSet<int>();
            HashSet<int> second = new HashSet<int>();
            int n = nm[0];
            int m = nm[1];
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                first.Add(number);
            }
            for (int i = 0; i < m; i++)
            {
                int number = int.Parse(Console.ReadLine());
                second.Add(number);
            }
            HashSet<int> intersection = first.Intersect(second).ToHashSet();
            Console.WriteLine(string.Join(" ",intersection));
        }
    }
}
