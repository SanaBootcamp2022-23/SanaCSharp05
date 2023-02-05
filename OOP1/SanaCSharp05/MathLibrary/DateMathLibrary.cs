using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.MathLibrary
{
    public static class DateMathLibrary
    {
        public static int GetDaysAmountInMonth(int month, int year)
        {
            if (month == 0) { return 0; }
            Dictionary<int, int> daysInMonth = new Dictionary<int, int>()
        {
            {1, 31},
            {2,28},
            {3,31},
            {4,30},
            {5,31},
            {6,30},
            {7,31},
            {8,31},
            {9,30},
            {10,31},
            {11,30},
            {12,31}
        };
            if (DateTime.IsLeapYear(year)) { daysInMonth[2] = 29; }
            return daysInMonth[month];
        }
    }
}
