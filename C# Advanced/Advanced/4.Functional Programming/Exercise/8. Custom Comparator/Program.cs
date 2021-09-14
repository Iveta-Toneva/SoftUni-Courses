using System;
using System.Linq;

namespace _2._Exer_08._Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbersInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Func<int, int, int> sort = (a, b) => a.CompareTo(b);

            Action<int[], int[]> print = (even, odd) => Console.WriteLine($"{string.Join(" ", even)} {string.Join(" ", odd)}");

            int[] evenNumbers = numbersInput.Where(x => x % 2 == 0).ToArray();

            int[] oddNumbers = numbersInput.Where(x => x % 2 != 0).ToArray();

            Array.Sort(evenNumbers, new Comparison<int>(sort));

            Array.Sort(oddNumbers, new Comparison<int>(sort));

            print(evenNumbers, oddNumbers);

        }
    }
}