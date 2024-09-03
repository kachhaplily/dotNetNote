using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class switchStatemnet
    {
        public switchStatemnet()
        {
            DateTime now = DateTime.Now;

            // Get the day of the week
            string dayOfWeek = now.DayOfWeek.ToString();

            // Display the day of the week
            Console.WriteLine("Today is: " + dayOfWeek);

            // Optional: Use a switch statement to provide a specific message
            switch (dayOfWeek)
            {
                case "Monday":
                    Console.WriteLine("Start of the work week!");
                    break;
                case "Tuesday":
                    Console.WriteLine("Second day of the work week.");
                    break;
                case "Wednesday":
                    Console.WriteLine("Midweek day.");
                    break;
                case "Thursday":
                    Console.WriteLine("Almost the end of the work week.");
                    break;
                case "Friday":
                    Console.WriteLine("End of the work week! Weekend is near.");
                    break;
                case "Saturday":
                    Console.WriteLine("Enjoy your weekend!");
                    break;
                case "Sunday":
                    Console.WriteLine("Relax and prepare for the week ahead.");
                    break;
            }
        }
    }
    
}
