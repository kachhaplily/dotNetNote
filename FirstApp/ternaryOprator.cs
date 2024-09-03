using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class ternaryOprator
    {
        public ternaryOprator()
        {
            Console.Write("Enter your age: ");
            var input = Console.ReadLine();

            // Use int.TryParse to validate and convert input
            if (int.TryParse(input, out int age))
            {
                // Use ternary operator for conditional message
                string message = age > 18
                    ? "You are able to drive the car"
                    : "No, you can't";
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}
