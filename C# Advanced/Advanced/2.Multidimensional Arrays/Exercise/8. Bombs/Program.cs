using System;
using System.Linq;

namespace _2._Exer_08._Bombs
{
    class Program
    {


        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int rows = input;
            int cols = input;

            int[,] matrix = ReadMatrix(rows, cols);

            string[] bombsRowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            bool[,] bombsLocations = new bool[rows, cols];

            for (int i = 0; i < bombsRowData.Length; i++)
            {
                int[] bombIndexes = bombsRowData[i].Split(',').Select(int.Parse).ToArray();
                int bombRow = bombIndexes[0];
                int bombCol = bombIndexes[1];

                bombsLocations[bombRow, bombCol] = true;

                if (bombsLocations[bombRow, bombCol] == true && matrix[bombRow, bombCol] > 0) // Ако бомбата е на текущото поле и е активна
                {
                    // един ред нагоре
                    if (bombRow - 1 >= 0)   // Проверка дали горния ред е в матрицата
                    {
                        if (matrix[bombRow - 1, bombCol] > 0) // Ако полето отгоре е > 0 го намаляме
                        {
                            matrix[bombRow - 1, bombCol] -= matrix[bombRow, bombCol];
                        }

                        if (bombCol - 1 >= 0)   // Проверка за полето по левия диагонал
                        {
                            if (matrix[bombRow - 1, bombCol - 1] > 0)     // Ако полето е > 0 го намаляме
                            {
                                matrix[bombRow - 1, bombCol - 1] -= matrix[bombRow, bombCol];
                            }
                        }

                        if (bombCol + 1 < matrix.GetLength(1))  // Проверка за полето по десния диагонал
                        {
                            if (matrix[bombRow - 1, bombCol + 1] > 0)   // Ако полето е > 0 го намаляме
                            {
                                matrix[bombRow - 1, bombCol + 1] -= matrix[bombRow, bombCol];
                            }
                        }
                    }

                    // за същия ред

                    if (bombCol - 1 >= 0)
                    {
                        if (matrix[bombRow, bombCol - 1] > 0)
                        {
                            matrix[bombRow, bombCol - 1] -= matrix[bombRow, bombCol];
                        }
                    }

                    if (bombCol + 1 < matrix.GetLength(1))
                    {
                        if (matrix[bombRow, bombCol + 1] > 0)
                        {
                            matrix[bombRow, bombCol + 1] -= matrix[bombRow, bombCol];
                        }
                    }

                    // един ред надолу

                    if (bombRow + 1 < matrix.GetLength(0))
                    {
                        if (matrix[bombRow + 1, bombCol] > 0)
                        {
                            matrix[bombRow + 1, bombCol] -= matrix[bombRow, bombCol];
                        }

                        if (bombCol - 1 >= 0)
                        {
                            if (matrix[bombRow + 1, bombCol - 1] > 0)
                            {
                                matrix[bombRow + 1, bombCol - 1] -= matrix[bombRow, bombCol];
                            }
                        }

                        if (bombCol + 1 < matrix.GetLength(1))
                        {
                            if (matrix[bombRow + 1, bombCol + 1] > 0)
                            {
                                matrix[bombRow + 1, bombCol + 1] -= matrix[bombRow, bombCol];
                            }
                        }
                    }

                    matrix[bombRow, bombCol] = 0; // детониране на бомбата
                }
            }

            Console.WriteLine($"Alive cells: {AliveCells(matrix)}");
            Console.WriteLine($"Sum: {SumMatrix(matrix)}");

            PrintMatrix(matrix);

        }

        static int AliveCells(int[,] matrix)
        {
            int alivecells = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        alivecells++;
                    }

                }
            }

            return alivecells;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        static int[,] ReadMatrix(int rows, int cols)
        {

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            return matrix;

        }


        static int SumMatrix(int[,] matrix)
        {
            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        sum += matrix[row, col];
                    }

                }
            }

            return sum;
        }


    }
}