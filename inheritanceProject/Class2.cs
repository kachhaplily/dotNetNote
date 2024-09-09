using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceProject
{


    internal class Class2 : Class1
    {

        public Class2()
        {
            Console.WriteLine("child class called");
        }
        public void test3()
        {
            Console.WriteLine("method 3");
        }
        static void Main(string[] args)
        {
            Class2 class2 = new Class2();
            class2.test1();
            class2.test2();
            class2.test3();
            

            Console.ReadLine();
        }
    }
}
