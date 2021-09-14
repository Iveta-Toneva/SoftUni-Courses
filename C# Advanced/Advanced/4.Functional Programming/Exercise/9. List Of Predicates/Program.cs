using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Exer_09._List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int endOfRange = int.Parse(Console.ReadLine());

            List<int> dividers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            Action<List<int>> print = number => Console.WriteLine(string.Join(" ", number));

            List<int> numbers = new List<int>();

            for (int i = 1; i <= endOfRange; i++)
            {
                bool isDivisible = true;

                foreach (var number in dividers)
                {
                    Predicate<int> notDivider = currentNumber => i % currentNumber != 0;

                    if (notDivider(number))
                    {
                        isDivisible = false;

                        break;
                    }
                }

                if (isDivisible)
                {
                    numbers.Add(i);
                }
            }

            print(numbers);

        }
    }
}