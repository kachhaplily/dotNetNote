using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class ParentOverride
    {

        public virtual void developer()
        {
            Console.WriteLine("i am developer");
        }

        public void methodHide()
        {
            Console.WriteLine("method is hide from parent");
        }
    }
}


/**
 * 
  virtual Used in the base class to declare a method that can be overridden in a derived class.
override	Used in the derived class to modify or extend the behavior of a virtual method.
new	Used to hide a base class method with the same name in the derived class, but this is not polymorphism. It hides the method, not overrides it.
 */
