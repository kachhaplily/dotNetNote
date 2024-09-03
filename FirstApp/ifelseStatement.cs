using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class ifelseStatement
    {
        public ifelseStatement()
        {
            Console.Write("Enter your age: ");
            var input = Console.ReadLine();

            if (int.TryParse(input, out int age))
            {
                if (age > 18)
                {
                    Console.WriteLine("You are able to driver the car");
                }
                else
                {
                    Console.WriteLine("no, you can't");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }


        }
    }
}
