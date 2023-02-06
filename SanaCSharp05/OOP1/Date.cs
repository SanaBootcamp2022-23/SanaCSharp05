using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Date
    {
        protected int Year = 2000;
        protected int Month = 1;
        protected int Day = 1;
        protected int Hours = 0;
        protected int Minutes = 0;
        public Date() { }
        public Date(int year, int month, int day, int hours, int minutes)
        {
            Year = year;
            if (IsCorrectMonth(month))
                Month = month;
            else
                throw new Exception("Incorrect month!");
            if (IsCorrectDay(day))
                Day = day;
            else
                throw new Exception("Incorrect day!");
            if (IsCorrectHour(hours))
                Hours = hours;
            else
                throw new Exception("Incorrect hour!");
            if (IsCorrectMinute(minutes))
                Minutes = minutes;
            else
                throw new Exception("Incorrect minute");
        }
        public Date(int year, int month, int day, int hours)
        {
            Year = year;
            Month = month;
            Day = day;
            Hours = hours;
        }
        public Date(Date obj)
        {
            Year = obj.Year;
            Month = obj.Month;
            Day = obj.Day;
            Hours = obj.Hours;
            Minutes = obj.Minutes;
        }
        public void GetFullDate()
        {
            Console.WriteLine($"{Day} DD {Month} MM {Year} YY | {Hours} Hours {Minutes} Minutes");
        }
        public int GetYear()
        {
            return Year;
        }
        public int GetMonth()
        {
            return Month;
        }
        public int GetDay()
        {
            return Day;
        }
        public int GetHour()
        {
            return Hours;
        }
        public int GetMinute()
        {
            return Minutes;
        }
        public bool IsCorrectMonth(int month)
        {
            if (month <= 12 && month > 0)
                return true;
            else
                return false;
        }
        public bool IsCorrectDay(int day) 
        {
            if (day <= 31 && day > 0)
                return true;
            else
                return false;
        }
        public bool IsCorrectHour(int hour)
        {
            if(hour <= 24 && hour >= 0)
                return true;
            else
                return false;
        }
        public bool IsCorrectMinute(int minute)
        {
            if (minute <= 60 && minute >= 0)
                return true;
            else
                return false;
        }
        public void SetYear(int year)
        {
            Year = year;
        }
        public void SetMonth(int month)
        {
            if (IsCorrectMonth(month))
                Month = month;
            else
                throw new Exception("Incorrect month!");
        }
        public void SetDay(int day)
        {
            if (IsCorrectDay(day))
                Day = day;
            else
                throw new Exception("Incorrect day!");
        }
        public void SetHour(int hour)
        {
            if (IsCorrectMinute(hour))
                Hours = hour;
            else
                throw new Exception("Incorrect hour!");
        }
        public void SetMinute(int minute)
        {
            if (IsCorrectMinute(minute))
                Minutes = minute;
            else
                throw new Exception("Incorrect minute!");
        }

    }
}
