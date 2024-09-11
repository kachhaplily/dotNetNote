using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class InterfaceEmbandedClass : interfaceTest,InterfaceTest2
    {
        public void sub(int a, int b)
        {
            var sub = a - b;
            Console.WriteLine(sub);
        }

        public void sum(int a, int b)
        {
            var sum = a+b;
            Console.WriteLine(sum);
        }


        static void Main(string[] args)
        {

           interfaceTest test = new InterfaceEmbandedClass();
            test.sub(0, 1);
            test.sum(0, 2);
            test.sum(0, 3);

            Console.ReadLine();
        }
    }

    
}
