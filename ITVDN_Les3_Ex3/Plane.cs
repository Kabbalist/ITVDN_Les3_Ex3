using System;
using System.Collections.Generic;
using System.Text;

namespace ITVDN_Les3_Ex3
{
    class Plane : Vehicle
    {
        public Plane (double height, int passCount, double price, double maxSpeed, double acceleration, double yearOfProd)
            : base (price, maxSpeed, acceleration, yearOfProd)   
        {
            Price = price;
            MaxSpeed = maxSpeed;
            Acceleration = acceleration;
            YearOfProduction = yearOfProd;
            Height = height;
            PassCount = passCount;
        }
        public double Height { get; set; }
        public int PassCount { get; set; }
    }
}
