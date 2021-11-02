using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const decimal CaffePrice = 3.50m;
        private const double CaffeMilliliters = 50;
        public Coffee(string name, double caffeine) : base(name, CaffePrice, CaffeMilliliters)
        {
           
            this.Caffeine = caffeine;
        }
        public double Caffeine  { get; set; }
    }
}
