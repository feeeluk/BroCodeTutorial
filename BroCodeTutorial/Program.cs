using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.Threading;

namespace BroCodeTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lesson 50 -  multithreading
            // thread = an execution path of a program
            // we cam use muliple threads to perform different tasks at the same time.
            // Current thread running is "main" thread
            // using System.Threading;
            
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";
            Console.WriteLine(mainThread.Name);

            Thread thread1 = new Thread(CountUp);
            Thread thread2 = new Thread(CountDown);

            thread1.Start();
            thread2.Start();

            // CountUp();
            // CountDown();

        }
        public static void CountUp()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Timer #1: " + i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #1 is COMPLETE");
        }
        public static void CountDown()
        {
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine("Timer #2: " + i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #2 is COMPLETE");
        }
    }
}