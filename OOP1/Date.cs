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



        public Date()
        {
            year = 2023;
            month = 1;
            day = 1;
            hours = 20;
            minutes = 43;
        }

        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public Date(int year, int month, int day, int hours, int minutes) : this(year, month, day)
        {
            this.hours = hours;
            this.minutes = minutes;
        }

        public Date(Date otherDate)
        {
            year = otherDate.year;
            month = otherDate.month;
            day = otherDate.day;
            hours = otherDate.hours;
            minutes = otherDate.minutes;
        }

        public int GetYear()
        {
            return year;
        }
        public void SetYear(int year)
        {
            this.year = year;
        }

        public int GetMonth()
        {
            return month;
        }
        public void SetMonth(int month)
        {
            this.month=month;
        }

        public int GetDay()
        {
            return day;
        }
        public void SetDay(int day)
        {
            this.day = day;
        }

        public int GetHours()
        {
            return hours;
        }
        public void SetHours(int hours)
        {
            this.hours = hours;
        }

        public int GetMinutes()
        {
            return minutes;
        }
        public void SetMinutes(int minutes)
        {
            this.minutes = minutes;
        }

    }

}
