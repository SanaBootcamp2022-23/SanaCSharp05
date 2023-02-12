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
        protected int month;
        protected int day;
        protected int hours;
        protected int minutes;

        public int Year
        {
            get { return year; }
            set { if (value > 0 && value <= 2023) year = value; }
        }

        public int Month
        {
            get { return month; }  
            set { if (value > 0 && value <= 12) month = value; }  
        }

        public int Day
        {
            get { return day; }
            set { if (value > 0 && value <= 31) day = value; }
        }

        public int Hours
        {
            get { return hours; }
            set { if (value < 0 && value <= 23) hours = value; }
        }

        public int Minutes
        {
            get { return minutes; }
            set { if (value > 0 && value <= 59) minutes = value; }
        }

        public Date(){ }

        public Date(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }

        public Date(int year, int month, int day, int hours, int minutes) : this(year, month, day)
        {
            Hours = hours;
            Minutes = minutes;
        }
        
        public Date(Date date)
        {
            Year = date.Year;
            Month = date.Month;
            Day = date.Day;
            Hours = date.Hours;
            Minutes = date.Minutes;
        }

    }


}
