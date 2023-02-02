using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Date
    {
        protected int year;
        protected int month;
        protected int day;
        protected int hours;
        protected int minutes;

        public Date() { }

        public Date(int year, int month, int day, int hours, int minutes)
        {
            this.year = year;
            this.month = month;
            this.day = day;
            this.hours = hours;
            this.minutes = minutes;
        }

        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public Date(int hours, int minutes)
        {
            this.hours = hours;
            this.minutes = minutes;
        }

        public Date(Date obj)
        {
            this.year = obj.year;
            this.month = obj.month;
            this.day = obj.day;
            this.hours = obj.hours;
            this.minutes = obj.minutes;
        }

        public int Year
        {
            get { return year; }
            set { if (value > 0) year = value; }
        }

        public int Month
        {
            get { return month; }
            set { if (value >= 1 && value <= 12) month = value; }
        }

        public int Day
        {
            get { return day; }
            set { if (value >= 1 && value <= 31) day = value; }
        }
        public int Hours
        {
            get { return hours; }
            set { if (value >= 0 && value <= 23) hours = value; }
        }
        public int Minutes
        {
            get { return minutes; }
            set { if (value >= 0 && value <= 60) minutes = value; }
        }
    }
}
