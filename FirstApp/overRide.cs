using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class overRide
    {

        public virtual void colorName()
        {
            Console.WriteLine("yellowe color");
        }

    }


    internal class overRide2 : overRide
    {

        static void Main(string[] args)
        {
            overRide2 ov= new overRide2();
            ov.colorName();
        }
    }
}
