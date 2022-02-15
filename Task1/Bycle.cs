using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Bycle : Vehicle
    {
        public override double Drive(double a)
        {
            Millage++;
            return Millage;
        }
    }
}
