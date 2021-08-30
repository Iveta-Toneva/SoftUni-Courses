using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Exer_8._Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            bool isBalanced = true;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '{' || input[i] == '[' || input[i] == '(')
                {
                    stack.Push(input[i]);
                    continue;
                }

                if (stack.Count == 0)
                {
                    isBalanced = false;
                    break;
                }

                if (stack.Peek() == '(' && input[i] == ')')
                {
                    stack.Pop();
                    continue;
                }
                if (stack.Peek() == '[' && input[i] == ']')
                {
                    stack.Pop();
                    continue;
                }
                if (stack.Peek() == '{' && input[i] == '}')
                {
                    stack.Pop();
                    continue;
                }
            }

            if (stack.Count == 0 && isBalanced == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }



        }
    }
}