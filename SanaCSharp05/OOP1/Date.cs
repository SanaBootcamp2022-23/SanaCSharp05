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
        public Date(int year, int month, int day, int hours, int minutes)
        {
            Year = year;
            Month = month;
            Day = day;
            Hours = hours;
            Minutes = minutes;
        }
        public Date(int year, int month, int day, int hours)
        {
            Year = year;
            Month = month;
            Day = day;
            Hours = hours;
            Minutes = 0;
        }
        public Date(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
            Hours = 0;
            Minutes = 0;
        }
        public Date(Date date)
        {
            Year = date.Year;
            Month = date.Month;
            Day = date.Day;
            Hours = date.Hours;
            Minutes = date.Minutes;
        }
        public int GetYear()
        {
            return Year;
        }
        public void SetYear(int year)
        {
            if (year >= 1990 && year <= 2023)
                Year = year;
            else
                Year = DateTime.Now.Year;
        }
        public int GetMonth()
        {
            return Month;
        }
        public void SetMonth (int month)
        {
            if (month >= 1 && month <= 12)
                Month = month;
            else
                Month = DateTime.Now.Month;
        }
        public int GetDay ()
        {
            return Day;
        }
        public void SetDay (int day)
        {
            if (day >= 1 && day <= 31)
                Day = day; 
            else 
                Day = DateTime.Now.Day;
        }
        public int GetHours()
        {
            return Hours;
        }
        public void SetHours (int hours)
        {
            if (hours >= 1 && hours <= 24)
                Hours = hours;
            else
                Hours = DateTime.Now.Hour;
        }
        public int GetMinutes()
        {
            return Minutes;
        }
        public void SetMinutes (int minutes)
        {
            if (minutes >= 1 && minutes <= 60) 
                Minutes = minutes;
            else 
                Minutes = DateTime.Now.Minute;
        }
    }
}
