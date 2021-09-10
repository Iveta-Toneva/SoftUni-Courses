using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> elements = new HashSet<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split().ToArray();
                for (int j = 0; j < data.Length; j++)
                {
                    string currentElement = data[j];
                    elements.Add(currentElement);
                }
            }
            elements = elements.OrderBy(x => x).ToHashSet();
            Console.WriteLine(string.Join(" ",elements));
        }
    }
}
