using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Date
    {
        protected int _year = 2023;
        public int Year
        {
            set {
                if (value >= 2023 && value <= 2025)
                {
                    _year = value;
                }
            }
            get { return _year; }
        }
        protected int _month = 2;
        public int Month
        {
            set
            {
                if (value >= 1 && value <= 12)
                {
                    _month = value;
                }
            }
            get { return _month; }
        }
        protected int _day = 8;
        int[] day = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        public int Day
        {
            set
            {
                if (value >= 1 && value <= day[_month-1])
                {
                    _day = value;
                }
            }
            get { return _day; }
        }
        protected int _hour = 12;
        public int Hour
        {
            set
            {
                if (value >= 0 && value <= 23)
                {
                    _hour = value;
                }
            }
            get { return _hour; }
        }
        protected int _minutes = 30;
        public int Minutes
        {
            set
            {
                if (value >= 0 && value <= 59)
                {
                    _minutes = value;
                }
            }
            get { return _minutes; }
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
        public Date(int year, int month, int day, int hour)
        {
            Year = year;
            Month = month;
            Day = day;
            Hour = hour;
        }
        public Date(int year, int month, int day, int hour, int minutes)
        {
            Year = year;
            Month = month;
            Day = day;
            Hour = hour;
            Minutes = minutes;
        }
        public Date(Date date)
        {
            Year = date._year;
            Month = date._month;
            Day = date._day;
            Hour = date._hour;
            Minutes = date._minutes;
        }
    }
}
