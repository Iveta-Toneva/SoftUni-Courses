using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Stack<string> stack = new Stack<string>();
            for (int i = input.Length-1; i >=0 ; i--)
            {
                stack.Push(input[i]);
            }
            while (stack.Count>1)
            {
                int leftNumber = int.Parse(stack.Pop());
                string sign = stack.Pop();
                int rightNumber = int.Parse(stack.Pop());
                if (sign=="+")
                {
                    stack.Push((leftNumber + rightNumber).ToString());
                }
                else if (sign=="-")
                {
                    stack.Push((leftNumber - rightNumber).ToString());
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
