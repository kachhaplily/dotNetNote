using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceProject
{
    internal class Class1
    {
        public Class1()
        {
            Console.WriteLine("parent class called");
        }
        public void test1()
        {
            Console.WriteLine("method 1");
        }

        public void test2()
        {
            Console.WriteLine("method 2");
        }

        private void test4()
        {
            Console.WriteLine("private method is called");
        }
    }
}
