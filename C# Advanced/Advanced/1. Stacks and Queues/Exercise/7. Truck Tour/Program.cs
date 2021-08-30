using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int pumps = int.Parse(Console.ReadLine());

            Queue<string> circle = new Queue<string>();

            for (int i = 0; i < pumps; i++)
            {
                string input = Console.ReadLine();

                input += $" {i}"; 

                circle.Enqueue(input);
            }

            int totalFuel = 0;

            for (int i = 0; i < pumps; i++)
            {
                string currentInfo = circle.Dequeue();

                int[] info = currentInfo.Split().Select(int.Parse).ToArray();

                int fuel = info[0];
                int distance = info[1];

                totalFuel += fuel;

                if (totalFuel >= distance)
                {
                    totalFuel -= distance;
                }
                else
                {
                    totalFuel = 0;
                    i = -1;
                }

                circle.Enqueue(currentInfo);

            }

            string[] firstElement = circle.Dequeue().Split().ToArray();

            Console.WriteLine(firstElement[2]);
        }
    }
}
