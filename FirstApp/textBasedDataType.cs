using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class textBasedDataType
    {
        // Declaring and initializing a string
        string greeting = "Hello, world!";

        // Concatenation
        string name = "Alice";

        public textBasedDataType()
        {
            string personalizedGreeting = greeting + " My name is " + name + ".";

            // Length of the string
            int length = greeting.Length;

            // Substring
            string part = greeting.Substring(7, 5); // Extracts "world"

            // Comparison
            bool areEqual = greeting.Equals("Hello, world!");

            // Displaying the results
            Console.WriteLine("Greeting: " + greeting);
            Console.WriteLine("Personalized Greeting: " + personalizedGreeting);
            Console.WriteLine("Length of Greeting: " + length);
            Console.WriteLine("Substring: " + part);
            Console.WriteLine("Are Greetings Equal? " + areEqual);

        }
    }
}
