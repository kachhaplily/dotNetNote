using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class booleanDataType
    {
        bool isFlag ;
       
        public booleanDataType()
        {
            if (5 > 10)
            {
                isFlag = false;
                Console.WriteLine(isFlag);
            }
            else
            {
                isFlag = true;
                Console.WriteLine(isFlag);
            }
        }
    }
}
