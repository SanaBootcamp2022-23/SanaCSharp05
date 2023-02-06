using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Date //оголошення класу
    {
        protected int Year;
        protected int Month;
        protected int Day;
        protected int Hours;
        protected int Minutes;
        public Date() //конструктор по-замовчуванню 
        {
            Year = DateTime.Now.Year;
            Month = DateTime.Now.Month;
            Day = DateTime.Now.Day;
            Hours = DateTime.Now.Hour;
            Minutes = DateTime.Now.Minute;
        }
        public Date(int year, int month, int day) //конструктор з параметрами
        {
            Year = year;
            Month = month;
            Day = day;
        }
        public Date(int hours, int minutes) //конструктор з параметрами
        {
            Hours = hours;
            Minutes = minutes;
        }
        public Date(Date obj) //конструктор копіювання
        {
            this.Year = obj.Year;
            this.Month = obj.Month;
            this.Day = obj.Day;
            this.Hours = obj.Hours;
            this.Minutes = obj.Minutes;
        }
        // реалізація властивостей Get- та Set-
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
            if (month > 0 && month <= 12)
            {
                Month = month;
            }
        }
        public void SetDay(int day)
        {
            if (day > 0 && day <= 31)
            {
                Day = day;
            }
        }
        public void SetHour(int hour)
        {
            if (hour > 0 && hour <= 24)
            {
                Hours = hour;
            }
        }
        public void SetMinutes(int minutes)
        {
            if (minutes > 0 && minutes <= 60)
            {
                Minutes = minutes;
            }
        }
    }
}
