using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Exer_07._Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int maxNameLength = int.Parse(Console.ReadLine());

            Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(x => x.Length <= maxNameLength).ToList().ForEach(Console.WriteLine);
        }
    }
}