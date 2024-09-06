using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class accessModifierThree
    {

        static void Main(string[] args)
        {
            accessModifier am = new accessModifier();
            am.test2();
            am.test4();
            am.test5();
           Console.ReadLine();
            

        }
    }

    //case : consuming member of class from non child class. 
    //can not access procted and private from this class.  
}
