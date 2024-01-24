using System.Security.Cryptography.X509Certificates;

namespace BroCodeTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lesson 42 - Polymorphism = A Greek word that means 'to have many forms'
            // Objects can be identified by more than one type
            // E.G. A dog is also: canine, animal, organism, mammal

            // Create instances (objects) of classes
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            // Load objects into array
            // Use polymorphism to load all 3 objects into an array as all three different types of object have the class Vehicle in common
            Vehicle[] vehicles = { car, bicycle, boat };

            foreach(Vehicle vehicle in vehicles)
            {
                vehicle.Go();
            }
        }
    }

    class Vehicle
    {
        public virtual void Go()
        {
        }
    }

    class Car : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("Car is moving!");
        }
    }
    
    class Bicycle : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("Bicycle is moving!");
        }
    }

    class Boat : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("Boat is moving!");
        }
    }
}

