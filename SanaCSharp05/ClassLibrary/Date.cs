using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Date
    {
        private const int CurrentYear = 2023, MaxMonthValue = 12, MaxDayValue = 31, MaxHourValue = 24,
            MaxMinuteValue = 60;

        protected int year = DateTime.Now.Year;
        protected int month = DateTime.Now.Month;
        protected int day = DateTime.Now.Day;
        protected int hours = DateTime.Now.Hour;
        protected int minutes = DateTime.Now.Minute;
        public int Year
        {
            get { return year; }
            set { if (value >= CurrentYear) year = value; }
        }
        public int Month
        {
            get { return month; }
            set { if (value > 0 && value < MaxMonthValue) month = value; }
        }
        public int Day
        {
            get { return day; }
            set { if (value > 0 && value <= MaxDayValue) day = value;}
        }
        public int Hours
        {
            get { return hours; }
            set { if (value >= 0 && value <= MaxHourValue) hours = value;}
        }
        public int Minutes
        {
            get { return minutes; }
            set { if (value >= 0 && value < MaxMinuteValue) minutes = value;}
        }

        public Date() 
        { 

        }

        public Date(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }

        public Date(int year, int month, int day, int hours, int minutes)
            : this(year, month, day)
        {
            Hours = hours;
            Minutes = minutes;
        }

        public Date(Date date) 
            : this(date.Year, date.Month, date.Day, date.Hours, date.Minutes)
        {

        }
    }
}
