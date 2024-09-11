using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class enumDemo
    {
        enum DaysOfWeek
        {
            Sunday,    // 0
            Monday,    // 1
            Tuesday,   // 2
            Wednesday, // 3
            Thursday,  // 4
            Friday,    // 5
            Saturday   // 6
        }

        static void Main(string[] args)
        {
            DaysOfWeek today = DaysOfWeek.Wednesday;
            Console.WriteLine(today); 
            Console.WriteLine((int)today);
            Console.ReadLine();

        }

    }

    //Enums are often used for situations where a variable can only take a fixed set of related values, making the code clearer and reducing errors.

}
