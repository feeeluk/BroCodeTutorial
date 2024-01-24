using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

namespace BroCodeTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lesson 44

            // lists = A data structure that represent a list of objects that can be accessed by index.
            // Similar to array, but can dynamically increase / decrease in size.
            // using System.Collection.Generic;

            // create an array to remind myself
            // String[] food = new String[3];

            // Create a list
            List<String> food = new List<String>();

            food.Add("Pizza");
            food.Add("Sandwich");
            food.Add("Pasta");
            food.Add("Hotdog");

            
            String[] foodArray = food.ToArray();
            Console.WriteLine(food[0]);
            food.Remove("Pasta");
            food.Insert(1, "sushi");
            Console.WriteLine(food.Count);
            Console.WriteLine(food.IndexOf("Sandwich"));

            Console.WriteLine();
            Console.WriteLine("##################");
            Console.WriteLine("ARRAY");
            Console.WriteLine("##################");
            Console.WriteLine();

            foreach (String item in foodArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("##################");
            Console.WriteLine("LIST");
            Console.WriteLine("##################");
            Console.WriteLine();

            foreach (String item in food)
            {
                Console.WriteLine(item);
            }
        }
    }
}