using System;
namespace OOP1
{
    public class Date
    {
        protected int year;
        public int Year
        {
            get { return year; }
            set { if (value > 1900) year = value; }
        }
        protected int month;
        public int Month
        {
            get { return month; }
            set { if (value >= 0 && value <= 12) month = value; }
        }
        protected int day;
        public int Day
        {
            get { return day; }
            set { if (value >= 0 && value <= 31) day = value; }
        }
        protected int hours;
        public int Hours
        {
            get { return hours; }
            set { if (value >= 0 && value <= 23) hours = value; }
        }
        protected int minutes;
        public int Minutes
        {
            get { return minutes; }
            set { if (value >= 0 && value <= 59) minutes = value; }
        }

        public Date()
        {
            Year = 2023;
            Month = 1;
            Day = 30;
            Hours = 12;
            Minutes = 30;
        }
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
