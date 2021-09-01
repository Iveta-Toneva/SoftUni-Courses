using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = sizes[0];
            int cols = sizes[1];
            int[,] matrix = new int[rows, cols];
            int sum = int.MinValue;
            int rowIndex = 0;
            int colIndex = 0;

            for (int row = 0; row <matrix.GetLength(0) ; row++)
            {

                int[] rowData = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    int sumMatrix = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];
                    if (sumMatrix>sum)
                    {
                        sum = sumMatrix;
                        rowIndex = row;
                        colIndex = col;
                    }
                }
            }
            Console.WriteLine(matrix[rowIndex, colIndex] + " " + matrix[rowIndex, colIndex + 1]);
            Console.WriteLine(matrix[rowIndex + 1, colIndex] + " " + matrix[rowIndex+ 1, colIndex + 1]);
            Console.WriteLine(sum);

        }
    }
}
