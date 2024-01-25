using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

namespace BroCodeTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lesson 46 - getters and setters = add security to fields by encapsulation
            // They are accessorts found within properties
            // Properties = combine aspects of both fields and methods (share name with a field (just as constructor does with a class))
            // Get accessor = used to return the propertyu value
            // Set accessor = used to assign a new value
            // Value keyword = defines the value being assigned by the set (parameter)

            Car car = new Car(400);

            car.Speed = 1000000000;

            Console.WriteLine(car.Speed);
        }

        class Car
        {
            public int speed;

            public Car(int speed)
            {
                Speed = speed;
            }

            public int Speed
            {
                get {  return speed; }

                set
                {
                    if (value > 500)
                    {
                        speed = 500;
                    }

                    else
                    {
                        speed = value;
                    }
                }   
            }
        }
    }
}