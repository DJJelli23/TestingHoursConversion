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
        bool fullHours_MinHours;

        decimal tempNeeded;

        const decimal TOTALHOURSNEEDEDPPMINHOURS = 86.67m;
        const decimal TOTALHOURSNEEDEDPPFULLHOURS = 88.00m;

        decimal days12Min = TOTALHOURSNEEDEDPPMINHOURS / 12;
        decimal days11Min = TOTALHOURSNEEDEDPPMINHOURS / 11;
        decimal days10Min = TOTALHOURSNEEDEDPPMINHOURS / 10;// 1 = 8.667, 2 = 17.334, 3 = 26.001, 4 = 34.668, 5 = 43.335, 6 = 52.002, 7 = 60.669, 8 = 69.336, 9 = 78.003, 10 = 86.67
		decimal days9Min = TOTALHOURSNEEDEDPPMINHOURS / 9;

        decimal days12Full = TOTALHOURSNEEDEDPPFULLHOURS / 12;
        decimal days11Full = TOTALHOURSNEEDEDPPFULLHOURS / 11;
        decimal days10Full = TOTALHOURSNEEDEDPPFULLHOURS / 10;
		decimal days9Full = TOTALHOURSNEEDEDPPFULLHOURS / 9;

        public decimal CalculatePayPeriodHoursNeeded(decimal curHours, int dpp, int currentDays, bool whichhours)
        {
            fullHours_MinHours = whichhours;
            if (!fullHours_MinHours)
            {
				if (dpp == 9)
				{
					hoursNeededToday = days9Min * currentDays;
					if (hoursNeededToday < curHours)
					{
						hoursToday = hoursNeededToday - curHours;//curHours - hoursNeededToday;
						tempNeeded = hoursToday + ((dpp - currentDays) * days9Min);
					}
					else
					{
						hoursToday = hoursNeededToday - curHours;
						tempNeeded = hoursToday + ((dpp - currentDays) * days9Min);
					}
				}
                else if (dpp == 10)
                {
                    hoursNeededToday = days10Min * currentDays;
                    if (hoursNeededToday < curHours)
                    {
                        hoursToday = hoursNeededToday - curHours;//curHours - hoursNeededToday;
                        tempNeeded = hoursToday + ((dpp - currentDays) * days10Min);
                    }
                    else
                    {
                        hoursToday = hoursNeededToday - curHours;
                        tempNeeded = hoursToday + ((dpp - currentDays) * days10Min);
                    }
                }
                else if (dpp == 11)
                {
                    hoursNeededToday = days11Min * currentDays;
                    currentHours = curHours;
                    if (hoursNeededToday < curHours)
                    {
                        hoursToday = hoursNeededToday - curHours;//curHours - hoursNeededToday;
                        tempNeeded = hoursToday + ((dpp - currentDays) * days11Min);
                    }
                    else
                    {
                        hoursToday = hoursNeededToday - curHours;
                        tempNeeded = hoursToday + ((dpp - currentDays) * days11Min);
                    }
                }
                else if (dpp == 12)
                {
                    hoursNeededToday = days12Min * currentDays;
                    currentHours = curHours;
                    if (hoursNeededToday < curHours)
                    {
                        hoursToday = hoursNeededToday - curHours;//curHours - hoursNeededToday;
                        tempNeeded = hoursToday + ((dpp - currentDays) * days12Min);
                    }
                    else
                    {
                        hoursToday = hoursNeededToday - curHours;
                        tempNeeded = hoursToday + ((dpp - currentDays) * days12Min);
                    }
                }
                hoursNeededForPP = tempNeeded;

                return hoursNeededForPP;
            }
            else
            {
				if (dpp == 9)
				{
					hoursNeededToday = days9Full * currentDays;
					if (hoursNeededToday < curHours)
					{
						hoursToday = hoursNeededToday - curHours;//curHours - hoursNeededToday;
						tempNeeded = hoursToday + ((dpp - currentDays) * days9Full);
					}
					else
					{
						hoursToday = hoursNeededToday - curHours;
						tempNeeded = hoursToday + ((dpp - currentDays) * days9Full);
					}
				}
				else if (dpp == 10)
                {
                    hoursNeededToday = days10Full * currentDays;
                    if (hoursNeededToday < curHours)
                    {
                        hoursToday = hoursNeededToday - curHours;//curHours - hoursNeededToday;
                        tempNeeded = hoursToday + ((dpp - currentDays) * days10Full);
                    }
                    else
                    {
                        hoursToday = hoursNeededToday - curHours;
                        tempNeeded = hoursToday + ((dpp - currentDays) * days10Full);
                    }
                }
                else if (dpp == 11)
                {
                    hoursNeededToday = days11Full * currentDays;
                    currentHours = curHours;
                    if (hoursNeededToday < curHours)
                    {
                        hoursToday = hoursNeededToday - curHours;//curHours - hoursNeededToday;
                        tempNeeded = hoursToday + ((dpp - currentDays) * days11Full);
                    }
                    else
                    {
                        hoursToday = hoursNeededToday - curHours;
                        tempNeeded = hoursToday + ((dpp - currentDays) * days11Full);
                    }
                }
                else if (dpp == 12)
                {
                    hoursNeededToday = days12Full * currentDays;
                    currentHours = curHours;
                    if (hoursNeededToday < curHours)
                    {
                        hoursToday = hoursNeededToday - curHours;//curHours - hoursNeededToday;
                        tempNeeded = hoursToday + ((dpp - currentDays) * days12Full);
                    }
                    else
                    {
                        hoursToday = hoursNeededToday - curHours;
                        tempNeeded = hoursToday + ((dpp - currentDays) * days12Full);
                    }
                }
                hoursNeededForPP = tempNeeded;

                return hoursNeededForPP;
            }
        }

        public decimal CalculateDayHoursNeeded(decimal curHours, int dpp, int currentDays)
        {
            if (!fullHours_MinHours)
            {
                if (dpp == 10)
                {
                    hoursNeededToday = days10Min * currentDays;
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
                    hoursNeededToday = days11Min * currentDays;
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
                    hoursNeededToday = days12Min * currentDays;
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
            else
            {
                if (dpp == 10)
                {
                    hoursNeededToday = days10Full * currentDays;
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
                    hoursNeededToday = days11Full * currentDays;
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
                    hoursNeededToday = days12Full * currentDays;
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
