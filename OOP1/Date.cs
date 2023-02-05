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
        public static Date Default = new Date(2023, 1, 1, 8, 0);
        public int Year
        {
            get { return year; }
            set { if (value > 0) year = value; }
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
        public int Hour
        {
            get { return hours; }
            set { if (value >= 0 && value <= 23) hours = value; }
        }
        public int Minute
        {
            get { return minutes; }
            set { if (value >= 0 && value <= 59) minutes = value; }
        }
        public Date() { }
        public Date(int Year, int Month, int Day, int Hours, int Minutes)
        {
            year = Year;
            month = Month;
            day = Day;
            hours = Hours;
            minutes = Minutes;
        }
        public Date(int Year, int Month, int Day)
        {
            year = Year;
            month = Month;
            day = Day;
        }
        public Date(Date PreviousDate)
        {
            year = PreviousDate.year;
            month = PreviousDate.month;
            day = PreviousDate.day;
            hours = PreviousDate.hours;
            minutes = PreviousDate.minutes;
        }
        public Date Copy()
        {
            return new(this);
        }
    }
}
