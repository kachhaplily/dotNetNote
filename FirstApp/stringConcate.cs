using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class stringConcate
    {
        public stringConcate()
        {
            string firstName = "John";
            string lastName = "Doe";

           
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            string fullName2 = String.Concat(firstName, " ", lastName);
            Console.WriteLine(fullName2);
            string fullName3 = $"{firstName} {lastName}";
            Console.WriteLine(fullName3);

            string[] names = { "John", "Doe" };
            string fullName4 = String.Join(" ", names);
            Console.WriteLine(fullName4);

            for (int i = 0; i < firstName.Length; i++)
            {
                Console.WriteLine(i);
            }



        }
    }
}
