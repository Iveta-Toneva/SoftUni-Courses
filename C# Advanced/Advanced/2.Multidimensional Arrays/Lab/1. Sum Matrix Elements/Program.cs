using System;
using System.Linq;

namespace Multidimensional_Arrays___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizeMatrix = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = sizeMatrix[0];
            int cols = sizeMatrix[1];
            int[,] matrix = new int[rows, cols];
            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col= 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                    sum += matrix[row, col];

                }
            }
            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);

        }
    }
}
