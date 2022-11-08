using System;

namespace Labb3_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometri geometri;

            geometri = new Cirkel();
            Console.WriteLine($"Area av cirklen: {geometri.Area()}");

            geometri = new Fyrkant();
            Console.WriteLine($"Area av cirklen: {geometri.Area()}");


        }
    }
}
