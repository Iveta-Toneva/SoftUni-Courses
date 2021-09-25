using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "Audi";
            car.Model = "A3";
            car.Year = 2019;
            Console.WriteLine($"{car.Make} - {car.Model} - {car.Year}");
        }
    }
}
