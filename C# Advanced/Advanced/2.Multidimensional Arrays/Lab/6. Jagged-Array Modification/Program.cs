using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jagged = new int[rows][];
            for (int i = 0; i < jagged.Length; i++)
            {
                jagged[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();


            }
            string command = Console.ReadLine();
            while (command!="END")
            {
                string[] dataCommand = command.Split();
                int row = int.Parse(dataCommand[1]);
                int col = int.Parse(dataCommand[2]);
                int value= int.Parse(dataCommand[3]);
                bool isInvalid = false;
                if (row >= jagged.Length || row < 0)
                {
                    isInvalid = true;
                }
                else if(jagged[row].Length <= col || col < 0)
                {

                    isInvalid = true;
                }
                if (isInvalid)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    if (command.StartsWith("Add"))
                    {
                        jagged[row][col] += value;
                    }
                    else if (command.StartsWith("Subtract"))
                    {
                        jagged[row][col] -= value;
                    }
                }

               



                command = Console.ReadLine();

            }
            foreach (var row in jagged)
            {
                Console.WriteLine(String.Join(" ", row));
            }
        }
    }
}
