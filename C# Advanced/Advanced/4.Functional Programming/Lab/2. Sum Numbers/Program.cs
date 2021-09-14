using System;
using System.Linq;

namespace _2._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            Action<int[]> PrintResult = Print;

            Print(input);

        }

        static void Print(int[] input)
        {
            Console.WriteLine(input.Count());
            Console.WriteLine(input.Sum()); ;
        }
    }
    
}
