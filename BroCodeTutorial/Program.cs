using System.Security.Cryptography.X509Certificates;

namespace BroCodeTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lesson 41 - ToString method = converts an object (an initition of a class) to its string representation so that it's suitable for dispaly

            Car car = new Car("Ford", "Focus", 2013, "Black");

            Console.WriteLine(car.ToString());

            // Alternatively just call the class as it invokes the ToString() method automatically
            Console.WriteLine("###############");
            Console.WriteLine(car);



        }
    }

    class Car
    {
        String make;
        String model;
        int year;
        String colour;

        public Car(String make, String model, int year, String colour)
        { 
            this.make = make;
            this.model = model;
            this.year = year;
            this.colour = colour;
        }
        public override string ToString()
        {
            String message = "This is a " + make + " " + model;
            return message;

            // alternatively we can return this directly
            // return "This is a " + make + " " + model;
        }

    }
}

