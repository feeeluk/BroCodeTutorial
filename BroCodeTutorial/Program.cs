namespace BroCodeTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lesson 37 - abstract keyword

            // Abstract class = modifier tjat indicates missing components or incomplete implementation
            // For example in the situation below, it is correct to create objects of the type Car or Bicycle or Boat, but Vehicle is not the whole picture..
            // To prevent a Vehicle object from being created we can use the 'abstract' keyword.

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();
          
        abstract class Vehicle
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
            int maxSpeed = 250;
        }

        class Bicycle : Vehicle
        {
            public int wheels = 2;
            int maxSpeed = 200;
        }

        class Boat : Vehicle
        {
            public int wheels = 0;
            int maxSpeed = 70;
        }
    }
}

