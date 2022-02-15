using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Car : Vehicle
    {
        public double FuelCapacity;
        public double CurrentFuel;
        public double FuelFor1Km;

        //public Car()
        //{
        //    FuelCapacity = 150;
        //    CurrentFuel = 126;
        //    FuelFor1Km = 1.2;
        //}
        public override double Drive(double a)
        {
            return FuelCapacity;
        }
    }
}
