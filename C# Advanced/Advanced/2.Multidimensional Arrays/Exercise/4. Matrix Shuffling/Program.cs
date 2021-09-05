using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = sizes[0];
            int cols = sizes[1];
            string[,] matrix = new string[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            
            while (true)
            {
                string command = Console.ReadLine();
                if (command=="END")
                {
                    break;
                }
                string[] data = command.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (IsValid(matrix,data))
                {
                    int rowFirst = int.Parse(data[1]);
                    int colFirst = int.Parse(data[2]);
                    int rowSecond = int.Parse(data[3]);
                    int colSecond = int.Parse(data[4]);
                   string firstElement = matrix[rowFirst, colFirst];
                string secondElement = matrix[rowSecond, colSecond];
                    matrix[rowSecond, colSecond] = firstElement;
                     matrix[rowFirst, colFirst] = secondElement;
                

                    
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            Console.Write(matrix[i, j] + " ");

                        }
                        Console.WriteLine();
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }




               
            }
           
        }

        private static bool IsValid(string[,] matrix,string[]command)
        {
           
            if (command.Length == 5 && command[0] == "swap" &&
                int.Parse(command[1]) >= 0 && int.Parse(command[1]) < matrix.GetLength(0)
                && int.Parse(command[2]) >= 0 && int.Parse(command[2]) < matrix.GetLength(1) &&
                int.Parse(command[3]) >= 0 && int.Parse(command[3]) < matrix.GetLength(0) &&
                int.Parse(command[4]) >= 0 && int.Parse(command[4]) < matrix.GetLength(1))
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }

     
    
}
