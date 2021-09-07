using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command=="END")
                {
                    break;
                }
                string[] data = command.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string directon = data[0];
                string car = data[1];
                if (directon=="IN")
                {
                    cars.Add(car);
                }
                else
                {
                    cars.Remove(car);
                }
            }
            if (cars.Count==0)
            {
                Console.WriteLine("Parking Lot is Empty");
                return;
            }
            foreach (var item in cars)
            {
                
                Console.WriteLine(item);
            }
        }
    }
}
