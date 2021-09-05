
using System;
using System.Linq;

namespace _2._Exer_06._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] JaggedArray = new double[rows][];

            for (int row = 0; row < rows; row++)
            {
                double[] currentRow = Console.ReadLine().Split().Select(double.Parse).ToArray();

                JaggedArray[row] = currentRow;

            }


            for (int row = 0; row < rows - 1; row++)
            {

                if (JaggedArray[row].Length == JaggedArray[row + 1].Length)
                {
                    for (int i = 0; i < JaggedArray[row].Length; i++)
                    {
                        JaggedArray[row][i] *= 2;

                        JaggedArray[row + 1][i] *= 2;

                    }
                }
                else
                {
                    for (int i = 0; i < JaggedArray[row].Length; i++)
                    {
                        JaggedArray[row][i] /= 2;
                    }

                    for (int i = 0; i < JaggedArray[row + 1].Length; i++)
                    {
                        JaggedArray[row + 1][i] /= 2;
                    }
                }
            }

            while (true)
            {
                string commands = Console.ReadLine();

                if (commands == "End")
                {

                    foreach (var item in JaggedArray)
                    {
                        Console.WriteLine(String.Join(" ", item));
                    }

                    return;
                }

                string[] splitted = commands.Split();

                int row = int.Parse(splitted[1]);
                int col = int.Parse(splitted[2]);
                int value = int.Parse(splitted[3]);

                if (row >= 0 && row < JaggedArray.GetLength(0) && col >= 0 && col < JaggedArray[row].Length)
                {
                    if (splitted[0] == "Add")
                    {
                        JaggedArray[row][col] += value;
                    }
                    else
                    {
                        JaggedArray[row][col] -= value;
                    }

                }
            }

        }
    }
}