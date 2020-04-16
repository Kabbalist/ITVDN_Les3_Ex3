using System;
using System.Collections.Generic;
using System.Text;

namespace ITVDN_Les3_Ex3
{
    class Vehicle
    {
        public Vehicle (double price, double maxSpeed, double acceleration, double yearOfProd)
        {
            Price = price;
            MaxSpeed = maxSpeed;
            Acceleration = acceleration;
            YearOfProduction = yearOfProd;
        }
        public double Price { get; set; }
        public double MaxSpeed { get; set; }
        public double Acceleration { get; set; }
        public double YearOfProduction { get; set; }
    }
}
