using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class childOverride:ParentOverride
    {

        public override void developer()
        {
            Console.WriteLine("i am frontend developer");
        }

        public new void methodHide()
        {
            Console.WriteLine("method hide from child class");
        }


        static void Main(string[] args) {
        
            childOverride cd = new childOverride();
            cd.developer();
            cd.methodHide();
            Console.ReadLine();

        }


    }

}
