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
        public Date()//конструктор по замовчуванню
        {
            Year = 23;
            Month = 02;
            Day = 18;
            Hours = 15;
            Minutes = 22;
        }
        public Date(int year, int month, int day, int hours, int minutes)//конструктор з параметром
        {
            Year = year;
            Month = month;
            Day = day;
            Hours = hours;
            Minutes = minutes;
        }
        public Date(int year, int month, int day)//конструктор з параметром
        {
            Year = year;
            Month = month;
            Day = day;
        }
        public Date(Date obj)//консруктор копіювання
        {
            Year = obj.Year;
            Month = obj.Month;
            Day = obj.Day;
            Hours = obj.Hours;
            Minutes = obj.Minutes;
        }
        //властивості Get- та Set-
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
        public int GetHours()
        {
            return Hours;
        }
        public int GetMinutes()
        {
            return Minutes;
        }
        public void SetYear(int year)
        {
            Year = year;
        }
        public void SetMonth(int month)
        {
            Month = month;
        }
        public void SetDay(int day)
        {
            Day = day;
        }
        public void SetHour(int hour)
        {
            Hours = hour;
        }
        public void SetMinutes(int minutes)
        {
           Minutes = minutes;
        }
    }
}
