using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class array
    {
        int[] numbers = { 1, 12, 3, 4, 15,2,42,2 };
        int[] copies = new int[7];



        public array()
        {
            //Array.Reverse(numbers);
            //Array.Sort(numbers);
            Array.Copy(numbers, copies,numbers.Length-1);
            int index = Array.IndexOf(numbers, 3);
            Console.WriteLine( "index of 3 is "+index);
            int result = Array.Find(numbers, n => n > 3); //Finds the first element that matches the specified condition.
            Console.WriteLine(result);

            int[] results = Array.FindAll(numbers, n => n % 2 == 0); //Finds all elements that match the specified condition and returns them as an array.

            foreach (int i in results)
            {
                Console.WriteLine($"value{i}");
            }

            bool exists = Array.Exists(numbers, n => n > 3); //check isarray or not return boolean value
            Console.WriteLine(exists);
            Array.Resize(ref numbers, 7); //change the size of an array

            foreach (int i in copies)
            {
                Console.WriteLine(i);
            }
        }
    }
}
