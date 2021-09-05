using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Exer_10._Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            char[,] matrix = new char[rows, cols];

            bool isWon = false;

            int playerRow = -1;
            int playerRCol = -1;



            for (int row = 0; row < rows; row++)
            {
                char[] colValues = Console.ReadLine().ToCharArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = colValues[col];

                    if (colValues[col] == 'P')
                    {
                        playerRow = row;
                        playerRCol = col;

                    }
                }
            }

            char[] directions = Console.ReadLine().ToCharArray();

            foreach (char direction in directions)
            {
                int currentPlayerRow = playerRow;
                int currentPlayerCol = playerRCol;


                switch (direction)
                {
                    case 'U':
                        currentPlayerRow++;

                        break;
                    case 'D':
                        currentPlayerRow++;

                        break;
                    case 'L':
                        currentPlayerCol--;


                        break;
                    case 'R':
                        currentPlayerCol++;

                        break;
                }

                isWon = IsWon(matrix, currentPlayerRow, currentPlayerCol);

                if (isWon)
                {
                    matrix[playerRow, playerRCol] = '.';


                }
                else
                {

                    if (matrix[currentPlayerRow, currentPlayerCol] == 'B')
                    {
                        matrix[playerRow, playerRCol] = '.';
                        playerRow = currentPlayerRow;
                        playerRCol = currentPlayerCol;

                    }
                    else
                    {
                        matrix[playerRow, playerRCol] = '.';
                        matrix[currentPlayerRow, currentPlayerCol] = 'P';
                        playerRow = currentPlayerRow;
                        playerRCol = currentPlayerCol;

                    }

                }

                List<int> bunnies = new List<int>();

                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (matrix[row, col] == 'B')
                        {
                            bunnies.Add(row);
                            bunnies.Add(col);
                        }
                    }
                }

                for (int i = 0; i < bunnies.Count; i += 2)
                {
                    int bunnyRow = bunnies[i];
                    int bunnyCol = bunnies[i + 1];

                    SpredBunny(matrix, bunnyRow, bunnyCol);
                }

                if (isWon || matrix[playerRow, playerRCol] == 'B')
                {
                    break;
                }

            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }

            if (isWon)
            {
                Console.WriteLine($"won: {playerRow} {playerRCol}");
            }
            else
            {
                Console.WriteLine($"dead: {playerRow} {playerRCol}");
            }

           

        }

        private static void SpredBunny(char[,] matrix, int bunnyRow, int bunnyCol)
        {
            if (bunnyRow - 1 >= 0)
            {
                matrix[bunnyRow - 1, bunnyCol] = 'B';
            }
            if (bunnyRow + 1 < matrix.GetLength(0))
            {
                matrix[bunnyRow + 1, bunnyCol] = 'B';
            }
            if (bunnyCol - 1 >= 0)
            {
                matrix[bunnyRow, bunnyCol - 1] = 'B';
            }
            if (bunnyCol + 1 < matrix.GetLength(1))
            {
                matrix[bunnyRow, bunnyCol + 1] = 'B';
            }



        }

        private static bool IsWon(char[,] matrix, int currentPlayerRow, int currentPlayerCol)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            return currentPlayerRow < 0 || currentPlayerRow >= n || currentPlayerCol < 0 || currentPlayerCol >= m;
        }
    }

}