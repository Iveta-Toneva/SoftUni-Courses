using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> dict = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split().ToArray();
                string name = data[0];
                decimal grade = decimal.Parse(data[1]);
                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, new List<decimal>());
                    dict[name].Add(grade);

                }
                else
                {
                    dict[name].Add(grade);
                }
            }
            foreach (var item in dict)
            {

                StringBuilder sb = new StringBuilder();
                foreach (var num in item.Value)
                {
                    sb.Append($"{num:f2} ");
                   
                }
                Console.WriteLine($"{item.Key} -> {sb}(avg: {item.Value.Average():f2})");

            }
        }
    }
}
