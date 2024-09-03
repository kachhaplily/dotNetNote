using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class forloop
    {
        public forloop()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            // Iterate through the array
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            while (numbers[numbers.Length - 1] > 0)
            {
                Console.WriteLine("while loop");
            }
        }
    }
}
