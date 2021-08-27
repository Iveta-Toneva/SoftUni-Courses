using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> indexes = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] =='(')
                {
                    indexes.Push(i);
                }
                if (input[i]==')')
                {
                    int startIndex = indexes.Pop();
                    int lastIndex = i;
                    Console.WriteLine(input.Substring(startIndex,lastIndex-startIndex+1));
                }
            }
        }
    }
}
