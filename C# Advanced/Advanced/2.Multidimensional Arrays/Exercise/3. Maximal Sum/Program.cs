using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = sizes[0];
            int cols = sizes[1];
            int[,] matrix = new int[rows, cols];
            int maxSum = 0;
            int maxIndexRow = 0;
            int maxIndexCol = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int currentNumber = matrix[row, col];
                    int currentSum = 0;
                    currentSum += currentNumber + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                    matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxIndexRow = row;
                        maxIndexCol = col;

                    }
                }
            }
            
            //Console.Write($"{matrix[maxIndexRow,maxIndexCol]} {matrix[maxIndexRow,maxIndexCol+1]} {matrix[maxIndexRow,maxIndexCol+2]}");
            //Console.WriteLine();
            //Console.Write($"{matrix[maxIndexRow+1,maxIndexCol]} {matrix[maxIndexRow+1,maxIndexCol+1]} {matrix[maxIndexRow+1,maxIndexCol+2]}");
            //Console.WriteLine();
            //Console.Write($"{matrix[maxIndexRow+2,maxIndexCol]} {matrix[maxIndexRow+2,maxIndexCol+1]} {matrix[maxIndexRow+2,maxIndexCol+2]}");
            //Console.WriteLine();


            Console.WriteLine($"Sum = {maxSum}");
            for (int i = maxIndexRow; i <= maxIndexRow + 2 ; i++)
            {
                for (int j = maxIndexCol; j <= maxIndexCol + 2; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();


            }
        }
    }
}
