namespace BroCodeTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lesson 38 - array of objects


            Car[] garage = new Car[3];

            Car car1 = new Car("Focus");
            Car car2 = new Car("Civic");
            Car car3 = new Car("Clio");

            garage[0] = car1;
            garage[1] = car2;
            garage[2] = car3;
            
            // write them out manually
            Console.WriteLine(garage[0].model);
            Console.WriteLine(garage[1].model);
            Console.WriteLine(garage[2].model);

            Console.WriteLine("#########");
            Console.WriteLine();

            // use a foreach loop
            foreach (Car car in garage)
            {
                Console.WriteLine(car.model);
            }

            Console.WriteLine("#########");
            Console.WriteLine();

            // load the objects into the array declaration = cleaner and simpler
            Car[] garage2 = {new Car("Focus"), new Car("Civic"), new Car("Clio") };
            
            // use a foreach loop
            foreach (Car car in garage2)
            {
                Console.WriteLine(car.model);
            }
            

        }

        class Car
        {
            public String model;

            public Car(String model)
            {
                this.model = model;
            }
        }
    }
}

