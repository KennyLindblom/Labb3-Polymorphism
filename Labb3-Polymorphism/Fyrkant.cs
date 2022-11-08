using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3_Polymorphism
{
     class Fyrkant : Geometri
    {
        public double Length { get; set; }

        public Fyrkant()
        {
            Length = 6;
        }

        override public double Area()
        {
            double area = Length * Length;
            return area;
        }
    }
}
