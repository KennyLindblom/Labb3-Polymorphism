using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3_Polymorphism
{
     class Rektangel : Geometri
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Rektangel()
        {
            Base = 9.01;
            Height = 2;
        }

        override public double Area()
        {
            double area = Base * Height;
            return area;
        }

    }
}
