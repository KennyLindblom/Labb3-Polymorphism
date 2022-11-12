using System;

namespace Labb3_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Geometri circle = new Cirkel();
            Console.WriteLine($"Area av cirklen: {circle.Area()}");

            Geometri fyrkant = new Fyrkant();
            Console.WriteLine($"Area av Fyrkant: {fyrkant.Area()}");

            Geometri rektangel = new Rektangel();
            Console.WriteLine($"Area av Rektangel: {rektangel.Area()}");



        }
    }
}
