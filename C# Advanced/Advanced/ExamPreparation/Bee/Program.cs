using System;
using System.Linq;

namespace Survivor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int beeRow = -1;
            int beeCol = -1;
            int flowers = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string line = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col];
                    if (matrix[row,col]=='B')
                    {
                        beeRow = row;
                        beeCol = col;
                    }
                }
            }
            string command = Console.ReadLine();
            while (command!="End")
            {
                matrix[beeRow, beeCol] = '.';
                if (command=="up")
                {
                    beeRow--;
                }
                else if (command=="down")
                {
                    beeRow++;
                }
                else if (command=="left")
                {
                    beeCol--;
                }
                else if (command=="right")
                {
                    beeCol++;
                }
                if (beeRow<0||beeRow>=n||beeCol<0||beeCol>=n)
                {
                    Console.WriteLine("The bee got lost!");
                    break;
                }
                if (matrix[beeRow,beeCol]=='f')
                {
                    flowers++;
                }
                if (matrix[beeRow, beeCol] == 'O')
                {
                    continue;
                }

                command = Console.ReadLine();
            }
            if (command=="End")
            {
                matrix[beeRow, beeCol] = 'B';
            }
            if (flowers>=5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {flowers} flowers!");
            }
            else
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5-flowers} flowers more");
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
