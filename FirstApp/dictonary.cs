using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class dictonary
    {
        public dictonary()
        {
            Dictionary<string, int> ageDictionary = new Dictionary<string, int>();

            // Adding key-value pairs to the dictionary
            ageDictionary.Add("Alice", 25);
            ageDictionary.Add("Bob", 30);
            ageDictionary.Add("Charlie", 35);

            // Accessing a value by its key
            int age = ageDictionary["Alice"];
            Console.WriteLine($"Alice's age is {age}.");

            // Checking if a key exists
            if (ageDictionary.ContainsKey("Bob"))
            {
                Console.WriteLine("Bob's age is in the dictionary.");
            }

            // Iterating over the dictionary
            foreach (var kvp in ageDictionary)
            {
                Console.WriteLine($"Name: {kvp.Key}, Age: {kvp.Value}");
            }
        }
    }
}
