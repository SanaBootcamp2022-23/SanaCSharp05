using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Date
    {
        protected int year;
        public int Year
        {
            set 
            {
                if (value > 2000 && value < 2050)
                    year = value;
            }

            get
            {
                return year;
            }
        }
        protected int month;
        public int Month
        {
            set
            {
                if (value > 0 && value < 13)
                    month = value;
            }

            get
            {
                return month;
            }
        }
        protected int day;
        public int Day
        {
            set
            {
                if (value > 0 && value < 32)
                    day = value;
            }
            get
            {
                return day;
            }
        }
        protected int hours;
        public int Hours
        {
            set
            {
                if (value >= 0 && value < 25)
                    hours = value;
            }
            get
            {
                return hours;
            }
        }
        protected int minutes;
        public int Minutes
        {
            set
            {
                if (value >= 0 && value < 61)
                    minutes = value;
            }
            get
            {
                return minutes;
            }
        }

        public Date()
        {
            Year = 2023;
            Month = 2;
            Day = 14;
            Hours = 16;
            Minutes = 15;
        }

        public Date (int year, int month, int day, int hours, int minutes)
        {
            Year = year;
            Month = month;
            Day = day;
            Hours = hours;
            Minutes = minutes;
        }

        public Date (int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
            Hours = 10;
            Minutes = 15;
        }
        public Date (Date copied) : this(copied.Year, copied.Month, copied.Day, copied.Hours, copied.Minutes)
        {

        }



    }
}
