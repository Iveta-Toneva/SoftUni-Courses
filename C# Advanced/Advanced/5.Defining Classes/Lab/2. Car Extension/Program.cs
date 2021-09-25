using System;

namespace CarManufacturer
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "Audi";
            car.Model = "A8";
            car.Year = 2018;
            car.FuelConsumption = 10;
            car.FuelQuantity = 100;
            car.Drive(10);
          

        }
    }
}
