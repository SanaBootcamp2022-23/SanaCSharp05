using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Classes.Journey
{
    public static class CalcLibrary
    {
        public static int CountDayInMonth(int month, int year)
        {
            int count = 0;
            if (month % 2 != 0)
            {
                if (month <= 7)
                    count = 31;
                else if (month > 7 && month <= 12)
                    count = 30;
            }
            else
            {
                if (month <= 6)
                    count = 30;
                else
                    count = 31;
            }
            if (month == 2)
            {
                if (LeapYear(year))
                    count = 29;
                else
                    count = 28;
            }

            return count;
        }

        public static bool LeapYear(int year)
        {
            if (year % 400 == 0 && year % 100 == 0)
                return true;
            return false;
        }


    }
}
