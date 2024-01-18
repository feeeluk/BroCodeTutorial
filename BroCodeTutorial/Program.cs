namespace BroCodeTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Static = a modifier to declare a 'static member', which BELONGS to the class itself rather than to any spcecific object within that class (e.g. a variable, or a method)
            // remember that when referencing - use the class name, not the unique individual constructors

            // Static can also be used for a class - meaning that you can't create different objects of that class

            Car Car1 = new Car("Focus");
            Car Car2 = new Car("Corvette");

            Console.WriteLine(Car.numberOfCars);

            Car.startRace();
        }

        class Car
        {
            String model;
            public static int numberOfCars;

            public Car(String model)
            {
                this.model = model;
                numberOfCars++;
            }

            public static void startRace()
            {
                Console.WriteLine("Start race!");
            }

        }
    }
}
