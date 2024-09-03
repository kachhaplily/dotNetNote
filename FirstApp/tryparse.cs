using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class tryparse
    {
        public tryparse()
        {
            string value = Console.ReadLine();

            int number;
            double doubleNumber;

            bool status= int.TryParse(value, out number);
            bool doubleStatus = double.TryParse(value,out doubleNumber);

            if (status)
            {
                Console.WriteLine("value parse");
            }
            else
            {
                Console.WriteLine("faild to parse to int");
            }

            if (doubleStatus)
            {
                Console.WriteLine("value parse to double");
            }
            else
            {
                Console.WriteLine("faild to parse double");
            }
        }
    }
}
