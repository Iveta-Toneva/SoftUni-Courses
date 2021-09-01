using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] dataRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = dataRow[col];
                }
            }
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                sum += matrix[i, i];
            }
            Console.WriteLine(sum);
            
        }
    }
}
