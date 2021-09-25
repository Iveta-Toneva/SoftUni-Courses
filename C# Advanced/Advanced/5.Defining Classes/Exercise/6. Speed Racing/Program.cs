using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();
                string model = data[0];
                double fuelAmount = double.Parse(data[1]);
                double fuelConsumption = double.Parse(data[2]);
                Car car = new Car(model, fuelAmount, fuelConsumption);
                cars.Add(car);

            }
          
            while (true)
            {
                string command = Console.ReadLine();
                if (command=="End")
                {
                    break;
                }
               
                string[] data = command.Split();
                string model = data[1];
                double amountKm = double.Parse(data[2]);
                Car car = cars.FirstOrDefault(x => x.Model == model);
                car.Drive(amountKm);

            }
            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:f2} {item.TravelledDistance}");
            }
        } 
    }
}
