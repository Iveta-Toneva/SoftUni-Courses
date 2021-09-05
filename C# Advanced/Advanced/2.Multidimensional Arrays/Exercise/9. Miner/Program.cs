using System;
using System.Linq;

namespace _2._Exer_09._Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            char[,] matrix = new char[matrixSize, matrixSize];

            string[] moves = Console.ReadLine().Split();

            int coals = 0;

            int[] startingPosition = new int[2];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] field = Console.ReadLine().Split().Select(char.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = field[col];

                    if (field[col] == 'c')
                    {
                        coals++;
                    }
                    else if (field[col] == 's')
                    {
                        startingPosition[0] = row;

                        startingPosition[1] = col;
                    }
                }
            }

            // PrintMatrix(matrix);

            int collectedCoals = 0;

            for (int currentMove = 0; currentMove < moves.Length; currentMove++)
            {
                if (moves[currentMove] == "up")
                {

                    if (startingPosition[0] - 1 >= 0) // да не излезе от полето
                    {
                        startingPosition[0] -= 1;  // преместваме го

                        if (matrix[startingPosition[0], startingPosition[1]] == 'c')
                        {
                            matrix[startingPosition[0], startingPosition[1]] = '*';
                            coals--;
                            collectedCoals++;
                        }
                        else if (matrix[startingPosition[0], startingPosition[1]] == 'e')
                        {
                            Console.WriteLine($"Game over! ({startingPosition[0]}, {startingPosition[1]})");
                            return;
                        }
                    }
                }
                else if ((moves[currentMove] == "down"))
                {

                    if (startingPosition[0] + 1 < matrix.GetLength(0)) // да не излезе от полето
                    {
                        startingPosition[0] += 1;  // преместваме го

                        if (matrix[startingPosition[0], startingPosition[1]] == 'c')
                        {
                            matrix[startingPosition[0], startingPosition[1]] = '*';
                            coals--;
                            collectedCoals++;
                        }
                        else if (matrix[startingPosition[0], startingPosition[1]] == 'e')
                        {
                            Console.WriteLine($"Game over! ({startingPosition[0]}, {startingPosition[1]})");
                            return;
                        }
                    }
                }
                else if ((moves[currentMove] == "left"))
                {

                    if (startingPosition[1] - 1 >= 0) // да не излезе от полето
                    {
                        startingPosition[1] -= 1;  // преместваме го

                        if (matrix[startingPosition[0], startingPosition[1]] == 'c')
                        {
                            matrix[startingPosition[0], startingPosition[1]] = '*';
                            coals--;
                            collectedCoals++;
                        }
                        else if (matrix[startingPosition[0], startingPosition[1]] == 'e')
                        {
                            Console.WriteLine($"Game over! ({startingPosition[0]}, {startingPosition[1]})");
                            return;
                        }
                    }
                }
                else if ((moves[currentMove] == "right"))
                {
                    if (startingPosition[1] + 1 < matrix.GetLength(1)) // да не излезе от полето
                    {
                        startingPosition[1] += 1;  // преместваме го

                        if (matrix[startingPosition[0], startingPosition[1]] == 'c')
                        {
                            matrix[startingPosition[0], startingPosition[1]] = '*';
                            coals--;
                            collectedCoals++;
                        }
                        else if (matrix[startingPosition[0], startingPosition[1]] == 'e')
                        {
                            Console.WriteLine($"Game over! ({startingPosition[0]}, {startingPosition[1]})");
                            return;
                        }
                    }

                }
            }

            if (coals == 0)
            {
                Console.WriteLine($"You collected all coals! ({startingPosition[0]}, {startingPosition[1]})");
            }
            else
            {
                Console.WriteLine($"{coals} coals left. ({startingPosition[0]}, {startingPosition[1]})");
            }

        }

        static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

    }
}