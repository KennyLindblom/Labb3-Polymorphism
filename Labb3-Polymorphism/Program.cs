using System;

namespace Labb3_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometri geometri;  //Objekt reference

            geometri = new Cirkel();
            Console.WriteLine($"Area av cirklen: {geometri.Area()}");

            geometri = new Fyrkant();
            Console.WriteLine($"Area av Fyrkant: {geometri.Area()}");

            geometri = new Rektangel();
            Console.WriteLine($"Area av Rektangel: {geometri.Area()}");



        }
    }
}
