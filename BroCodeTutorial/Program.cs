using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

namespace BroCodeTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lesson 49 - generics = not specific to a particular data type
            // add <T> to: classes, methods, fields, etc.
            // allows for code reusibilty for different data types

            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 1.5, 2.5, 3.5 };
            String[] stringArray = { "1", "2", "3"};

            DisplayArray(intArray);
            DisplayArray(doubleArray);
            DisplayArray(stringArray);

        }

        public static void DisplayArray<T>(T[] array)
        {
            foreach(T I in array)
            {
                Console.Write(I + ", ");               
            }
            Console.WriteLine();
        }
    }
}