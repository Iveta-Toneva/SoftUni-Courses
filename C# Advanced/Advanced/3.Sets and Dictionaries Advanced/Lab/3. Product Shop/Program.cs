using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> dict = new SortedDictionary<string, Dictionary<string, double>>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command=="Revision")
                {
                    break;
                }
                string[] data = command.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string shop = data[0];
                string product = data[1];
                double priceProduct = double.Parse(data[2]);
                if (!dict.ContainsKey(shop))
                {
                    dict.Add(shop, new Dictionary<string, double>());
                   
                }
                
                if (!dict[shop].ContainsKey(product))
                {
                    dict[shop].Add(product, priceProduct);
                }

            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}->");
                foreach (var product in item.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
