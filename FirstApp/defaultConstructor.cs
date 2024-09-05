using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class defaultConstructor
    {
        public defaultConstructor()
        {
            Console.WriteLine("default constructor called");
            Console.ReadLine();

        }

        static void Main(string[] args)
        {
            defaultConstructor obj = new defaultConstructor();
        }
    }
}
