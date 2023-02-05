using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Date
    {
        protected int _year = DateTime.Now.Year;
        protected int _month = DateTime.Now.Month;
        protected int _day = DateTime.Now.Day;
        protected int _hours = DateTime.Now.Hour;
        protected int _minutes = DateTime.Now.Minute;

        public Date()
        {

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
        public Date(Date date)
        {
            Year = date.Year;
            Month = date.Month;
            Day = date.Day;
            Hours = date.Hours;
            Minutes = date.Minutes;
        }

        public int Year
        {
            set
            {
                if (value > 0)
                {
                    _year = value;
                }
            }
            get { return _year; }
        }
        public int Month
        {
            set
            {
                if (value > 0 && value <= 12)
                {
                    _month = value;
                }
            }
            get { return _month; }
        }
        public int Day
        {
            set
            {
                if (Month == 2 && value > 0 && value <= 28)
                {
                    _day = value;
                }
                else if ((Month == 4 || Month == 6 || Month == 9 || Month == 11) && value > 0 && value <= 30)
                {
                    _day = value;
                }
                else if ((Month == 1 || Month == 3 || Month == 5 || Month == 7 || Month == 8 || Month == 10 || Month == 12) && value > 0 && value <= 31)
                {
                    _day = value;
                }
            }
            get { return _day; }
        }
        public int Hours
        {
            set
            {
                if (value >= 0 && value < 24)
                {
                    _hours = value;
                }
            }
            get { return _hours; }
        }
        public int Minutes
        {
            set
            {
                if (value >= 0 && value < 60)
                {
                    _minutes = value;
                }
            }
            get { return _minutes; }
        }
        public DateTime FullDate()
        {
            return new DateTime(Year, Month, Day, Hours, Minutes, 0);
        }
    }
}
