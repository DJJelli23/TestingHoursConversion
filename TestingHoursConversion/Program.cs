using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingHoursConversion
{
    class Program
    {
        static void Main(string [] args)
        {
            decimal currentHours;
            int daysInPayPeriod;
            int currentDaysInPayPeriod;
            bool minOrFull = false;

            TotalAmountForPayPeriod yep = new TotalAmountForPayPeriod();

            Console.WriteLine("Are you trying to get Full or Minimal hours?");
            if(Console.ReadLine().ToLower() == "full")
            {
                minOrFull = true;
            }
            else //if (Console.ReadLine().ToLower() == "minimal" || Console.ReadLine().ToLower() == "min")
            {
                minOrFull = false;
            }

            Console.WriteLine("Enter the hours you currently have.");
            currentHours = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("How many days in the current pay period. Example 10 or 11");
            daysInPayPeriod = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("How many days are you in the current pay period.");
            currentDaysInPayPeriod = Convert.ToInt16(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Hours still needed on pay period: " + yep.ConvertDecimalToHours(yep.CalculatePayPeriodHoursNeeded(currentHours, daysInPayPeriod, currentDaysInPayPeriod, minOrFull)));
            Console.WriteLine("Hours still needed by the end of the day: " + yep.ConvertDecimalToHours(yep.CalculateDayHoursNeeded(currentHours, daysInPayPeriod, currentDaysInPayPeriod)));
            Console.Read();
        }
    }
}
