using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Exer_06._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersInput = Console.ReadLine().Split().Select(int.Parse).Reverse().ToArray();

            int divider = int.Parse(Console.ReadLine());

            Func<int, bool> isDivisible = x => x % divider != 0;

            Console.WriteLine(String.Join(" ", numbersInput.Where(isDivisible)));

           
        }
    }
}