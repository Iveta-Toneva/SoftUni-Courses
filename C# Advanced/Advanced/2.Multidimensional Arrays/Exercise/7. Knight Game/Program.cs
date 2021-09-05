using System;
using System.Linq;

namespace _2._Exer_07._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int rows = n;
            int cols = n;

            char[,] chessBoard = ReadMatrix(rows, cols);

           

            int countReplaced = 0;
            int rowKiller = 0;
            int colKiller = 0;

            while (true)
            {
                int maxAttacks = 0;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        char currentSymbol = chessBoard[row, col];

                        int countAttacks = 0;


                        if (currentSymbol == 'K')
                        {
                            
                            if (IsInside(chessBoard, row - 2, col + 1) && chessBoard[row - 2, col + 1] == 'K')
                            {
                                countAttacks++;
                            }
                            if (IsInside(chessBoard, row - 2, col - 1) && chessBoard[row - 2, col - 1] == 'K')
                            {
                                countAttacks++;
                            }
                            if (IsInside(chessBoard, row + 1, col + 2) && chessBoard[row + 1, col + 2] == 'K')
                            {
                                countAttacks++;
                            }
                            if (IsInside(chessBoard, row + 1, col - 2) && chessBoard[row + 1, col - 2] == 'K')
                            {
                                countAttacks++;
                            }
                            if (IsInside(chessBoard, row - 1, col + 2) && chessBoard[row - 1, col + 2] == 'K')
                            {
                                countAttacks++;
                            }
                            if (IsInside(chessBoard, row - 1, col - 2) && chessBoard[row - 1, col - 2] == 'K')
                            {
                                countAttacks++;
                            }
                            if (IsInside(chessBoard, row + 2, col - 1) && chessBoard[row + 2, col - 1] == 'K')
                            {
                                countAttacks++;
                            }
                            if (IsInside(chessBoard, row + 2, col + 1) && chessBoard[row + 2, col + 1] == 'K')
                            {
                                countAttacks++;
                            }

                            if (countAttacks > maxAttacks)
                            {
                                maxAttacks = countAttacks;
                                rowKiller = row;
                                colKiller = col;
                            }


                        }
                    }


                }

                if (maxAttacks > 0)
                {
                    chessBoard[rowKiller, colKiller] = 'O';
                    countReplaced++;
                }
                else
                {
                    Console.WriteLine(countReplaced);
                    break;
                }
            }


        }

        static char[,] ReadMatrix(int rows, int cols)
        {

            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            return matrix;

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

        private static bool IsInside(char[,] chessBoard, int targetRow, int TargetCol)
        {
            return targetRow >= 0 && targetRow < chessBoard.GetLength(0) && TargetCol >= 0 && TargetCol < chessBoard.GetLength(1);
        }
    }
}