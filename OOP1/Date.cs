using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Date
    {
        protected int Year;
        protected int Month;
        protected int Day;
        protected int Hour;
        protected int Minute;
        public Date()
        {
            Year = 2010;
            Month = 3;
            Day = 30;
            Hour = 12;
            Minute = 20;
        }
        public Date(int year, int month, int day, int hour, int minute)
        {
            Year = year;
            Month = month;
            Day = day;
            Hour = hour;
            Minute = minute;
        }
        public Date(int year, int month, int day, int hour)
        {
            Year = year;
            Month = month;
            Day = day;
            Hour = hour;
            Minute = 00;
        }
        public Date(Date obj)
        {
            Year = obj.Year;
            Month = obj.Month;
            Day = obj.Day;
            Hour = obj.Hour;
            Minute = obj.Minute;
        }

        // Getters / Setters down
        public void SetYear(int year)
        {
            Year = year;
        }
        public int GetYear()
        {
            return Year;
        }
        public void SetMonth(int month)
        {
            Month = month;
        }
        public int GetMonth()
        {
            return Month;
        }
        public void SetDay(int day)
        {
            Day = day;
        }
        public int GetDay()
        {
            return Day;
        }
        public void SetHours(int hours)
        {
            Hour = hours;
        }
        public int GetHour()
        {
            return Hour;
        }
        public void SetMinutes(int minutes)
        {
            Minute = minutes;
        }
        public int GetMinute()
        {
            return Minute;
        }
        public override string ToString()
        {
           return $"{Hour}:{Minute} {Day}.{Month}.{Year}";
        }
    }
}
