using System.Security.Cryptography.X509Certificates;

namespace BroCodeTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lesson 40 - method overriding = provides a new version of a method inherited from a parent class

            // inherited method must be: abstract || virtual || already overriden
            // use keyword override
            // used with ToString(), polymorphism

            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Speak();
            cat.Speak();

        }
    }

    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("the animal goes 'burrr'");
        }
    }

    class Dog : Animal
    {
        public override void  Speak()
        {
            Console.WriteLine("the dog goes 'woof'");
        }
    }

    class Cat : Animal
    {

    }

}

