using System.Security.Cryptography.X509Certificates;

namespace BroCodeTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lesson 43 - Interfaces = defines a 'contract' that all the classes inheriting from should follow
            // An interace declares 'what a class should have
            // An inheriting class defines 'how it should do it'

            // The benefit = security + multiple inheritance + 'plug-and-play' code

            Rabbit rabbit1 = new Rabbit();
            Hawk hawk1 = new Hawk();
            Fish fish1 = new Fish();

            rabbit1.Flee();
            hawk1.Hunt();
            fish1.Flee();
            fish1.Hunt();

        }
    }

    interface IPrey
    {
        void Flee();
    }

    interface IPredator
    {
        void Hunt();
    }
    
    class Rabbit : IPrey
    {
        public void Flee()
        {
            Console.WriteLine("The rabbit runs away");
        }
    }

    class Hawk : IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("The hawk hunts");
        }
    }

    class Fish : IPrey, IPredator
    {
        public void Flee()
        {
            Console.WriteLine("The fish swims away");
        }

        public void Hunt()
        {
            Console.WriteLine("The fish hunts for other fish");
        }
    }
}

