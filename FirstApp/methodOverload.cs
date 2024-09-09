using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class methodOverload
    {

        public void test()
        {
            Console.WriteLine("without perameter called");
        }

        public void test(int i) {

            Console.WriteLine("with int perameter called");
        }

        public void test(string s) {

            Console.WriteLine("with string perameter called");
        }

        public void test(int i , string s) {

            Console.WriteLine("string and int both called");
        }
       

        static void Main(string[] arga)
        {

            methodOverload m=new methodOverload();
            m.test();
            m.test(10);
            m.test("testing");
            m.test(1, "testing2");
            Console.ReadLine();

        }
    }
}
