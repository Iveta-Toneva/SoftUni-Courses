using System;

namespace CarManufacturer
{
     public class StartUp
    {
        static void Main(string[] args)
        {
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());
            Engine engine = new Engine(2017, 1200);
            Tire[] tires = new Tire[]
              {
            new Tire(2017, 1200),
            new Tire(2018, 1200),
              };
            Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engine, tires);


        }
    }
}
