using oop1;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();
                string model = data[0];
                int engineSpeed = int.Parse(data[1]);
                int eniginePower = int.Parse(data[2]);
                Engine engine = new Engine(engineSpeed, eniginePower);
                int cargoWeight = int.Parse(data[3]);
                string cargoType = data[4];
                Cargo cargo = new Cargo(cargoType, cargoWeight);
                Tire[] tires = new Tire[4];
                int count = 0;
                for (int j = 5; j < data.Length; j+=2)
                {
                   
                   
                    double tirePressure = double.Parse(data[j]);
                    int tireAge = int.Parse(data[j + 1]);
                    tires[count] = new Tire(tireAge,tirePressure);
                    count++;
                      
                }
                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);



            }
            string type = Console.ReadLine();
            if (type=="fragile")
            {
                var fragile = cars.Where(x => x.Cargo.CargoType == "fragile").Where(x => x.Tires.Any(p => p.TirePressure < 1)).ToList();
                foreach (var item in fragile)
                {
                    Console.WriteLine($"{item.Model}");
                }
            }
            else if (type=="flamable")
            {
                List<Car> flamable = cars.Where(x => x.Cargo.CargoType == "flamable").Where(x => x.Engine.EnginePower > 250).ToList();
                foreach (var item in flamable)
                {
                    Console.WriteLine($"{item.Model}");
                }
            }
            
        } 
    }
}
