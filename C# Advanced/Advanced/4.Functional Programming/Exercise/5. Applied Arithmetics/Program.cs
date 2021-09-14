
using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Exer_05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumber = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            Func<List<int>, List<int>> add = x => x.Select(number => number += 1).ToList();

            Func<List<int>, List<int>> multiply = x => x.Select(number => number * 2).ToList();

            Func<List<int>, List<int>> substract = x => x.Select(number => number -= 1).ToList();

            Action<List<int>> print = x => Console.WriteLine(string.Join(" ", x));

            string command = Console.ReadLine();

            while (command != "end")
            {

                if (command == "add")
                {
                    inputNumber = add(inputNumber);
                }
                else if (command == "multiply")
                {
                    inputNumber = multiply(inputNumber);
                }
                else if (command == "subtract")
                {
                    inputNumber = substract(inputNumber);
                }
                else if (command == "print")
                {
                    print(inputNumber);
                }

                command = Console.ReadLine();

            }

        }
    }
}