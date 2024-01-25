using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

namespace BroCodeTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lesson 48 - enums = special 'class' that contains a set of named integer constants.
            // Use enums when you have values that you know will not change.
            // To get the integer value from an item, you must explicitly convert to an int.
            // name = integer

            Console.WriteLine(Planets.Mercury);
            Console.WriteLine((int)Planets.Earth);

            Console.WriteLine("#######################");

            String name = PlanetsRadius.Earth.ToString();
            int radius = (int)PlanetsRadius.Earth;
            double volume = Volume(PlanetsRadius.Earth);

            Console.WriteLine("Planet: " + name);
            Console.WriteLine("Radius: " + radius);
            Console.WriteLine("Volume: " + volume);

        }

        public static double Volume(PlanetsRadius radius)
        {
            double volume = (4.0/3.0) * Math.PI * Math.Pow((int)radius,3);
            return volume;
        }
    }

    enum Planets
    {
        Mercury,
        Venus,
        Earth,
        Mars,
        Juipiter,
        Saturn,
        Uranus,
        Neptune,
        Pluto
    }

    enum PlanetsRadius
    {
        Mercury = 2439,
        Venus = 6051,
        Earth = 6371,
        Mars = 3389,
        Juipiter = 69911,
        Saturn = 58232,
        Uranus = 25362,
        Neptune = 24622,
        Pluto = 1188
    }
}