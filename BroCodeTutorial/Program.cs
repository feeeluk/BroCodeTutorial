namespace BroCodeTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lesson 35 - overloaded constructors

            // Overloaded constructors =    a technique to create multiple constructors with a different set of parameters.
            //                              name + parameters = signature

            //                              exactly the same principal as overloaded methods

            Pizza pizzaFour = new Pizza("regular", "red sauce", "mozzarella", "meat feast");
            Pizza pizzaThree = new Pizza("regular", "red sauce", "mozzarella");
            Pizza pizzaTwo = new Pizza("regular", "red sauce");
            Pizza pizzaOne = new Pizza("regular");


            Console.ReadKey();
        }

        class Pizza
        {
            String bread;
            String sauce;
            String cheese;
            String topping;

            public Pizza(String bread)
            {
                this.bread = bread;
            }

            public Pizza(String bread, String sauce)
            {
                this.bread = bread;
                this.sauce = sauce;
            }

            public Pizza(String bread, String sauce, String cheese)
            {
                this.bread = bread;
                this.sauce = sauce;
                this.cheese = cheese;
            }

            public Pizza(String bread, String sauce, String cheese, String topping)
            {
                this.bread = bread;
                this.sauce = sauce;
                this.cheese = cheese;
                this.topping = topping;
            }

        }

    }
}
