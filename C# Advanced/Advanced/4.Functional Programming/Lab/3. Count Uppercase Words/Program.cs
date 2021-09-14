using System;
using System.Linq;

namespace _3._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Func<string, bool> func = word => char.IsUpper(word[0]);
            text = text.Where(func).ToArray();
            Console.WriteLine(string.Join(Environment.NewLine,text));

        }
    }
}
