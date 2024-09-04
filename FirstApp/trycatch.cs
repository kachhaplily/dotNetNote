using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class trycatch
    {
        public trycatch()
        {
            try
            {
                // Code that might throw an exception
                int number =Convert.ToInt32(  Console.ReadLine());
                Console.WriteLine(number);
            }
            catch (FormatException ex)
            {
                // Handle specific exception
                Console.WriteLine("FormatException caught: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle any other exception
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                // Code that runs regardless of exception occurrence
                Console.WriteLine("This block always executes.");
            }

        }
    }
}
