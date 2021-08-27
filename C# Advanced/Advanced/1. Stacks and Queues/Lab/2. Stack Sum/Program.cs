using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                stack.Push(numbers[i]);
            }

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                if (command.Contains("add"))
                {
                    string[] splitted = command.Split();
                    stack.Push(int.Parse(splitted[1]));
                    stack.Push(int.Parse(splitted[2]));
                }
                else if (command.Contains("remove"))
                {
                    string[] splitted = command.Split();
                    int countToRemove = int.Parse(splitted[1]);
                    if (countToRemove <= stack.Count)
                    {
                        for (int i = 0; i < countToRemove; i++)
                        {
                            stack.Pop();
                        }
                    }
                }


                command = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
