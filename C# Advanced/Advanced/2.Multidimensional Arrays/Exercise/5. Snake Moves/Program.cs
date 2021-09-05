using System;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = sizes[0];
            int cols = sizes[1];
            string snake = Console.ReadLine();
            int currentLetter = 0;
            
            char[,] matrix = new char[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row%2==0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = snake[currentLetter];
                        currentLetter++;
                        if (currentLetter==snake.Length)
                        {
                            currentLetter = 0;
                        }
                    }
                    
                }
                else
                {
                    
                    for (int i = matrix.GetLength(1) - 1; i >= 0; i--)
                    {
                        matrix[row, i] = snake[currentLetter];
                        currentLetter++;
                        if (currentLetter==snake.Length)
                        {
                            currentLetter = 0;
                        }
                    }
                }
               
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
            

        }
    }
}
