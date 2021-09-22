using System;
using System.Collections.Generic;
using System.Text;

namespace oop1
{
    public class Cargo
    {
        public Cargo(string cargoType,int cargoWeight)
        {
            this.CargoType = cargoType;
            this.CargoWeight = cargoWeight;
        }
        public string CargoType { get; set; }
        public  int CargoWeight { get; set; }
    }
}
