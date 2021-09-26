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
                string dataValue = Console.ReadLine();
                list.Add(dataValue);
            }
            Box<string> box = new Box<string>(list);
            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstIndex = data[0];
            int secondIndex = data[1];
            box.SwapElement(firstIndex, secondIndex);
            Console.WriteLine(box);
           
            
        }
    }
}
