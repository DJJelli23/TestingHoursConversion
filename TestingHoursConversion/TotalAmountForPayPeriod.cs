using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingHoursConversion
{
    class TotalAmountForPayPeriod
    {
        decimal currentHours;
        decimal hoursToday;
        decimal hoursNeededToday;
        decimal hoursNeededForPP;

        decimal tempNeeded;

        const decimal TOTALHOURSNEEDEDPP = 86.67m;

        decimal days12 = TOTALHOURSNEEDEDPP / 12;
        decimal days11 = TOTALHOURSNEEDEDPP / 11;
        decimal days10 = TOTALHOURSNEEDEDPP / 10;// 1 = 8.667, 2 = 17.334, 3 = 26.001, 4 = 34.668, 5 = 43.335, 6 = 52.002, 7 = 60.669, 8 = 69.336, 9 = 78.003, 10 = 86.67

        

        public decimal CalculatePayPeriodHoursNeeded(decimal curHours, int dpp, int currentDays)
        {
            if (dpp == 10)
            {
                hoursNeededToday = days10 * currentDays;
                if (hoursNeededToday < curHours)
                {
                    hoursToday = hoursNeededToday - curHours;//curHours - hoursNeededToday;
                    tempNeeded = hoursToday + ((dpp - currentDays) * days10);
                }
                else
                {
                    hoursToday = hoursNeededToday - curHours;
                    tempNeeded = hoursToday + ((dpp - currentDays) * days10);
                }
            }
            else if (dpp == 11)
            {
                hoursNeededToday = days11 * currentDays;
                currentHours = curHours;
                if (hoursNeededToday < curHours)
                {
                    hoursToday = hoursNeededToday - curHours;//curHours - hoursNeededToday;
                    tempNeeded = hoursToday + ((dpp - currentDays) * days11);
                }
                else
                {
                    hoursToday = hoursNeededToday - curHours;
                    tempNeeded = hoursToday + ((dpp - currentDays) * days11);
                }
            }
            else if (dpp == 12)
            {
                hoursNeededToday = days12 * currentDays;
                currentHours = curHours;
                if (hoursNeededToday < curHours)
                {
                    hoursToday = hoursNeededToday - curHours;//curHours - hoursNeededToday;
                    tempNeeded = hoursToday + ((dpp - currentDays) * days12);
                }
                else
                {
                    hoursToday = hoursNeededToday - curHours;
                    tempNeeded = hoursToday + ((dpp - currentDays) * days12);
                }
            }
            hoursNeededForPP = tempNeeded;

            return hoursNeededForPP;
        }

        public decimal CalculateDayHoursNeeded(decimal curHours, int dpp, int currentDays)
        {

            if (dpp == 10)
            {
                hoursNeededToday = days10 * currentDays;
                if (hoursNeededToday < curHours)
                {
                    hoursToday = hoursNeededToday - curHours;//curHours - hoursNeededToday;
                }
                else
                {
                    hoursToday = hoursNeededToday - curHours;
                }
            }
            else if (dpp == 11)
            {
                hoursNeededToday = days11 * currentDays;
                currentHours = curHours;
                if (hoursNeededToday < curHours)
                {
                    hoursToday = hoursNeededToday - curHours;//curHours - hoursNeededToday;
                }
                else
                {
                    hoursToday = hoursNeededToday - curHours;
                }
            }
            else if (dpp == 12)
            {
                hoursNeededToday = days12 * currentDays;
                currentHours = curHours;
                if (hoursNeededToday < curHours)
                {
                    hoursToday = hoursNeededToday - curHours;//curHours - hoursNeededToday;
                }
                else
                {
                    hoursToday = hoursNeededToday - curHours;
                }
            }

            return hoursToday;
        }

        public string ConvertDecimalToHours(decimal totalDec)
        {
            decimal minutes;
            decimal seconds;

            int tempWholeHours;
            decimal tempRemaining;
            decimal secTemp;

            int minutesWhole;
            int secondsWhole;

            tempWholeHours = (int)totalDec; // = 54
            tempRemaining = totalDec - tempWholeHours; // = .42

            minutes = tempRemaining * 60; // = 25.2
            minutesWhole = (int)minutes; // = 25

            seconds = minutes - minutesWhole; // = .2
            secTemp = seconds * 60; // = 12

            secondsWhole = (int)Math.Round(secTemp); // = 12

            int totalHours = tempWholeHours;

            string totalStatement = "";

            totalStatement = "Answer: " + totalHours + "h:" + minutesWhole + "m:" + secondsWhole + "s";
            return totalStatement;
        }
    }
}
