using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class accessModifier
    {

        private void test1()
        {
            Console.WriteLine("private method call");
        }

        internal void test2() 
        {
            Console.WriteLine("internal method call");
        }

        protected void test3()
        {
            Console.WriteLine("protected method called");
        }

        protected internal void test4()
        {
            Console.WriteLine("procted internal method called");
        }

        public void test5()
        {
            Console.WriteLine("public method called");
        }

        static void Main(string[] arga)
        {

            accessModifier accessModifier = new accessModifier();
            accessModifier.test1();
            accessModifier.test2();
            accessModifier.test3();
            accessModifier.test4();
            accessModifier.test5();

            Console.ReadLine();

        }


        



    }
}
