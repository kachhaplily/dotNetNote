using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class InputOutPut
    {
        public InputOutPut()
        {
            Console.WriteLine("enter your name");

            string name = Console.ReadLine();

            Console.WriteLine($"Name is {name}");
        }
    }
}
