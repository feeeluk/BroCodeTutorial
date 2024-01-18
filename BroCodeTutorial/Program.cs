namespace BroCodeTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Constructor = A special method in a class used to create an object (instance of the class)
            // Use the same name as the class name
            // They can be used to assign arguments to fields when creating objects

            Car Car1 = new Car("Ford", "Focus", 2013, "Black");
            Car Car2 = new Car("Chevy", "Corvette", 2023, "Red");

            Car1.showDetails();

            Console.WriteLine();

            Car2.showDetails();
        }

        class Car
        {
            public String manufacturer;
            public String model;
            public int year;
            public String colour;

            public Car(String manufacturer, String model, int year, String colour)
            {
                this.manufacturer = manufacturer;
                this.model = model;
                this.year = year;
                this.colour = colour;
            }

            public void showDetails()
            {
                Console.WriteLine("Manufacturer: " + manufacturer);
                Console.WriteLine("Model: " + model);
                Console.WriteLine("Year: " + year);
                Console.WriteLine("Colour: " + colour);
            }
        }
    }
}
