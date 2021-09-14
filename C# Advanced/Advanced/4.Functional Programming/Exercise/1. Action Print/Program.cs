using System;
using System.Linq;

namespace Functional_Programming___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> printAction = Console.WriteLine;

            Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList().ForEach(printAction);
        }
    }
}
