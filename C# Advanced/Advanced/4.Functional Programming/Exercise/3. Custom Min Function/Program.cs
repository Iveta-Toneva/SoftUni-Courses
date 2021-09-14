using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            Action<int> print = Console.WriteLine;

            Func<List<int>, int> FindMin = x => x.Min();

            print(FindMin(numbers));
        }
    }
}
