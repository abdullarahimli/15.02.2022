using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    abstract class Vehicle
    {
        public string Color;
        public string Brand;
        public double Millage;

        //public Vehicle()
        //{
        //    Color = "Red";
        //    Brand = "BMW";
        //    Millage = 116000;
        //}

        public virtual string  ShowInfo()
        {
            return $"{Color} {Brand} {Millage}";
        }

        public abstract double Drive(double a);
        
    }
}
