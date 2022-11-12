using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3_Polymorphism
{
     class Geometri   //Parent Class 
    {
        virtual public double Area() //Funktionen som alla andra klasser använders sig av och overridar.
        {
            double area = 0;
            return area;
        }
    }
}
