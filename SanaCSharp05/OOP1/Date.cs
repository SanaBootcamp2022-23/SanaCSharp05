using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Date
    {
        private int year;
        public int Year
        {
            set { year = value; }
            get { return year; }
        }
        private int month { set; get; }
        public int Month
        {
            set { month = value; }
            get { return month; }
        }
        private int day { set; get; }
        public int Day
        {
            set { day = value; }
            get { return day; }
        }
        private int hours { set; get; }
        public int Hours
        {
            set { hours = value; }
            get { return hours; }
        }
        private int minutes { set; get; }
        public int Minutes
        {
            set { minutes = value; }
            get { return minutes; }
        }


        public Date(int Year, int Month, int Day)
        {
            year = Year;
            month = Month;
            day = Day;
            hours = 0;
            minutes = 0;
        }
        public Date(int Year, int Month, int Day,int Hours, int Min)
        {
            year = Year;
            month = Month;
            day = Day;
            hours = Hours;
            minutes = Min;
        }

        public Date()
        { }

        public Date(Date date)
        {
            year = date.year;
            month = date.month;
            day = date.day;
            hours = date.hours;
            minutes = date.minutes;
        }


    }
}
