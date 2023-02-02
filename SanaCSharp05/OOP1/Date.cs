using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Date
    {

        public int Year{get; set; }

        public int Month { get {return month; } set { month = Math.Clamp(value, 1, 12); } }
        protected int month;

        public int Day { get { return day; } set { day = Math.Clamp(value, 1, 31); } }
        protected int day;

        public int Hours { get { return hours; } set { hours = Math.Clamp(value, 0, 23); } }
        protected int hours;

        public int Minutes { get { return minutes; } set { minutes = Math.Clamp(value, 0, 59); } }
        protected int minutes;

        //constructors
        public Date()
        {
            Year = 1970;
            Month = 1;
            Day = 1;
            Hours = 0;
            Minutes = 0;
        }

        public Date(int year, int month, int day, int hours, int minutes)
        {
            Year = year;
            Month = month;
            Day = day;
            Hours = hours;
            Minutes = minutes;
        }

        public Date(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }
        public Date(Date obj)
        {
            Year = obj.Year;
            Month = obj.Month;
            Day = obj.Day;
            Hours = obj.Hours;
            Minutes = obj.Minutes;
        }

    }
}
