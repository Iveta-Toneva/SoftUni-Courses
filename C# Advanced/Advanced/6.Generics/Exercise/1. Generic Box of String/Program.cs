using System;

namespace GenericExcercises
{
   public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string data = Console.ReadLine();
                Box<string> box = new Box<string>(data);
                Console.WriteLine(box);
            }
        }
    }
}
