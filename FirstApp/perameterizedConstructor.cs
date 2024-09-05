using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class perameterizedConstructor
    {
        public perameterizedConstructor(int i)
        {
            Console.WriteLine(i);
           

        }

        static void Main(string[] args)
        {
            perameterizedConstructor obj = new perameterizedConstructor(10);
            perameterizedConstructor obj1 = new perameterizedConstructor(20);
            Console.ReadLine();
        }
    }
}
