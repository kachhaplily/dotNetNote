using System;

namespace FirstApp
{
    internal class StaticConstructor
    {
        public static int StaticValue;

        // Static constructor to initialize static members
        static StaticConstructor()
        {
            StaticValue = 10;
            Console.WriteLine("Static constructor called.");
        }

        // Instance constructor
        public StaticConstructor()
        {
            Console.WriteLine("Instance constructor called.");
            Console.WriteLine("StaticValue: " + StaticValue);
        }

        static void Main(string[] args)
        {
            // Create an instance of the class
            StaticConstructor obj = new StaticConstructor();

            // Keep the console open
            Console.ReadLine();
        }
    }
}
