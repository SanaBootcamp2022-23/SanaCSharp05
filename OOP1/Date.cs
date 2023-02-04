using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Date
    {
        protected int Year;
        protected int Month;
        protected int Day;
        protected int Hours;
        protected int Minutes;

        public Date()
        {
            Year = DateTime.Now.Year;
            Month = DateTime.Now.Month;
            Day = DateTime.Now.Day;
            Hours = DateTime.Now.Hour;
            Minutes = DateTime.Now.Minute;
        }
        public Date(int year, int month, int day, int hours, int minutes):this(year,month,day)
        {
            this.Hours = hours;
            this.Minutes=minutes;
        }

        public Date(int year, int month, int day)
        {
            this.Year = year;
            this.Month = month;
            this.Day = day;
            this.Hours = 0;
            this.Minutes = 0;
        }

        public Date(Date obj)
        {
            this.Year = obj.Year;
            this.Month = obj.Month;
            this.Day = obj.Day;
            this.Hours = obj.Hours;
            this.Minutes = obj.Minutes;
        }

        public void SetYear(int year)
        {
            if (year >= DateTime.Now.Year)
            {
                this.Year = year;
            }
        }

        public void SetMonth(int month)
        {
            if (month > 0 && month <= 12)
            {
                this.Month = month; 
            }
        }

        public void SetDay(int day)
        {
            if (day > 0 && day <= 31)
            {
                this.Day = day;
            }
        }

        public void SetHours(int hours)
        {
            if (hours >= 0 && hours < 24)
            {
                this.Hours = hours;
            }
        }

        public void SetMinutes(int minutes)
        {
            if (minutes >= 0 && minutes < 60)
            {
                this.Minutes = minutes;
            }
        }


        public int GetYear()
        {
            return this.Year;
        }

        public int GetMonth()
        {
            return this.Month;
        }

        public int GetDay()
        {
            return this.Day;
        }

        public int GetHours()
        {
            return this.Hours;
        }

        public int GetMinutes()
        {
            return this.Minutes;
        }
    }
}
