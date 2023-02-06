using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP1.MathLibrary;

namespace OOP1.Classes
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
            set
            {
                year = value;
            }
        }
        public int Month
        {
            get { return month; }
            set
            {
                if (value >= 1 && value <= 12)
                {
                    month = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Month must be between 1 and 12.", nameof(month));
                }
            }
        }
        public int Day
        {
            get { return day; }
            set
            {
                if (value >= 1 && value <= DateMathLibrary.GetDaysAmountInMonth(month, year))
                {
                    day = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"For month {month} day must be between 1 and {DateMathLibrary.GetDaysAmountInMonth(month, year)}.", nameof(day));
                }
            }
        }
        public int Hours
        {
            get { return hours; }
            set
            {
                if (value >= 0 && value < 24)
                {
                    hours = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"Hour must be between 0 and 24.", nameof(hours));
                }
            }
        }
        public int Minutes
        {
            get
            {
                return minutes;
            }
                set
            {
                if (value >= 0 && value < 60)
                {
                    minutes = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"Minute must be between 0 and 24.", nameof(minutes));
                }
            }
        }
        public Date(int year, int month, int day, int hour, int minute)
        {
            Year = year;
            Month = month;
            Day = day;
            Hours = hour;
            Minutes = minute;
        }
        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
            Hours = 0;
            Minutes = 1;
        }
        public Date(Date date)
        {
            Day = date.Day;
            Month = date.Month;
            Year = date.Year;
            Hours = date.Hours;
            Minutes = date.Minutes;
        }
        public Date()
        {
            Day = 1;
            Month = 1;
            Year = 1970;
            Hours = 0;
            Minutes = 0;
        }
    }
}
