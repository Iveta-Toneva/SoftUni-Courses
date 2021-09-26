using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericExcercises
{
   public class Program
    {
        static void Main(string[] args)
        {
            List<double> list = new List<double>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                double data = double.Parse(Console.ReadLine());
                list.Add(data);
            }
            Box<double> box = new Box<double>(list);
            double elementToCompare = double.Parse(Console.ReadLine());
            int count=box.BiggerElements(elementToCompare);
            Console.WriteLine(count);
            
        }
    }
}
