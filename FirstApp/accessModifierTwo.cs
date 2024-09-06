using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class accessModifierTwo :accessModifier
    {
        static void Main()
        {
            accessModifierTwo accessModifierTwo = new accessModifierTwo();
            accessModifierTwo.test2();
            accessModifierTwo.test3();
            accessModifierTwo.test4();
            accessModifierTwo.test5();

            Console.ReadLine();
        }
    }
}

//we can not declare class a private , procted , and procted internal.
//we can create only internal and public class. 
