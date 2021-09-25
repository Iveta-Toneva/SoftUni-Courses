using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefiningClasses
{
     public class Car
    {
        public Car(string model,double fuelAmount,double fuelConsumptionPerKilometer)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            this.TravelledDistance = 0;

        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }
        public void Drive(double amountOfKm)
        {
            bool canDrive = FuelAmount - FuelConsumptionPerKilometer * amountOfKm >= 0;
            if (canDrive)
            {
                TravelledDistance += amountOfKm;
                FuelAmount -= FuelConsumptionPerKilometer * amountOfKm;

            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }


    }
}
