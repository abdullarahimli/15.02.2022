using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Color = "Red";
            car.Brand = "BMW";
            car.Millage = 123456;
            car.CurrentFuel = 124;
            Bycle bycle = new Bycle();
            
            
            

            Console.WriteLine(car.ShowInfo());
        }
    }
}
