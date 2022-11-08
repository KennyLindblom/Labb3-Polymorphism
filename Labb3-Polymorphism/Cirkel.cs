using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3_Polymorphism
{
     class Cirkel : Geometri
    {
        public double Radius { get; set; }
        public double Pi { get; set; }

        public Cirkel()
        {
            Radius = 5;
            Pi = 3.14;
            
        }

        public override double Area()
        {
            double area = Radius * Radius * Pi;
            return area;
        }
    }
}
