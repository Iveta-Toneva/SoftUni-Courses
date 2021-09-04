using System;
using System.Linq;

namespace Multidimensional_Arrays___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int primariSum = 0;
            int secondarySum = 0;

            for (int row = 0; row < n; row++)
            {
                int[] rowData = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    int currentNumber = matrix[row, col];
                    if (row==col)
                    {
                        primariSum += currentNumber;
                    }
                    if (col==n-1-row)
                    {
                        secondarySum += currentNumber;
                    }
                }
            }
            Console.WriteLine($"{Math.Abs(primariSum-secondarySum)}");

        }
    }
}
