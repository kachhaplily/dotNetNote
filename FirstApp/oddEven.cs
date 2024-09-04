using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class oddEven
    {
        public oddEven()
        {

            //create list of even odd number
            
            List<int> even = new List<int>();
            List<int> odd = new List<int>();

            for (int i = 0; i < 100; i++)
            {

                if (i % 2 == 0)
                {
                    even.Add(i);
                }
                else
                {
                    odd.Add(i);
                }
            }


            //print even number from list
            foreach (int i in even)
            {
                Console.WriteLine($"even number {i}");
            }

            //print odd number form list
            foreach(int i in odd)
            {
                Console.WriteLine($"odd number {i}");
            }
        }
    }
}
