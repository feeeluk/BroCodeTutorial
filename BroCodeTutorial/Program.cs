namespace BroCodeTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lesson 36 - inheritance

            // Inheritance =    1 or more child classes recieving fields, methods, etc. from a common parent

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            Console.WriteLine(car.speed);
            Console.WriteLine(car.wheels);
            car.details();

            Console.WriteLine(bicycle.speed);
            Console.WriteLine(bicycle.wheels);
            bicycle.details();

            Console.WriteLine(boat.speed);
            Console.WriteLine(boat.wheels);
            boat.details();

        }

        class Vehicle
        {
            public int speed = 0;

            public void details()
            {
                Console.WriteLine("The vehicle details are:");
            }
        }

        class Car : Vehicle
        {
            public int wheels = 4;
        }

        class Bicycle : Vehicle
        {
            public int wheels = 2;
        }

        class Boat : Vehicle
        {
            public int wheels = 0;
        }
    }
}
