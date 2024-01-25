using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

namespace BroCodeTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lesson 47 - auto implemented properties = shortcut when no additional logic is required in the property
            // you do not have to define a field for a property.
            // you only have write get; and /or set; insdie the property

            Car car = new Car("Focus");

            Console.WriteLine(car.Model);
        }
    }

    class Car
    {
        public String Model { get; set; }
        
        /*
        String model;

        public String Model
        {
            get { return model; }
            set { model = value; }
        }
        */

        public Car(string model)        {
            this.Model = model;
        }

    }
}