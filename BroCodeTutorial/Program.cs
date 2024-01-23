using System.Security.Cryptography.X509Certificates;

namespace BroCodeTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lesson 39 - Objects as arguments

            Car car1 = new Car("Focus", "Black");

            // Console.WriteLine(car1.colour + " " + car1.model);
            // Console.WriteLine("###########");
            // ChangeColour(car1,"White");
            // Console.WriteLine(car1.colour + " " +car1.model);

            Car car2 = Copy(car1);
            Console.WriteLine(car2.colour + " " +car2.model);
        }

        public static void ChangeColour(Car car, String colour)
        {
            car.colour = colour;
        }

        public static Car Copy(Car carCopy)
        {
            return new Car(carCopy.model, carCopy.colour);
        }
    }

    class Car
    {
        public String model;
        public String colour;

        public Car(String model, string colour)
        {
            this.model = model;
            this.colour = colour;
        }
    }
}

