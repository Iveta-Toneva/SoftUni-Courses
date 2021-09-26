using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericExcercises
{
   public class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string data = Console.ReadLine();
                list.Add(data);
            }
            Box<string> box = new Box<string>(list);
            string elementToCompare = Console.ReadLine();
            int count=box.BiggerElements(elementToCompare);
            Console.WriteLine(count);
            
        }
    }
}
