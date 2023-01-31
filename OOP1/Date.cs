using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Date
    {
        protected int year = 0;
        protected int month = 1;
        protected int day = 1;
        protected int hours = 0;
        protected int minutes = 0;
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
            set { if (value > 0 && value < 32) day = value; }
        }
        public int Hours
        {
            get { return hours; }
            set { if (value >= 0 && value < 24) hours = value; }
        }
        public int Minutes
        {
            get { return minutes; }
            set { if(value >= 0 && value < 60) minutes = value; }
        }

        public Date() { }
        public Date(int year, int month, int day, int hours, int minutes)
        {
            this.year = year;
            this.month = month;
            this.day = day;
            this.hours = hours;
            this.minutes = minutes;
        }
        public Date(int year, int month, int day, int hours) : this(year, month, day, hours, 0) { }

        public Date(Date date) : this(date.year, date.month, date.day, date.hours, date.minutes) { }
        
    }
}