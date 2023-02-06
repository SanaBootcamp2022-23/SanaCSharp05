using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
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
            Year = 2022;
            Month = 12;
            Day = 08;
            Hours = 06;
            Minutes = 12;
        }
        public Date(int year, int month, int day, int hours, int minutes)
        {
            Year = year;
            Month = month;
            Day = day;
            Hours = hours;
            Minutes = minutes;
        }
        public Date(int year, int month)
        {
            Year = year;
            Month = month;
            Day = 08;
            Hours = 12;
            Minutes = 08;
        }
        public Date(int day, int hours, int minutes)
        {
            Year = 2000;
            Month = 05;
            Day = day;
            Hours = hours;  
            Minutes = minutes;

        }
        public Date(Date obj)
        {
            Year=obj.Year;  
            Month=obj.Month;
            Day=obj.Day;
            Hours=obj.Hours;
            Minutes=obj.Minutes;
        }
        public void SetYear(int year) { Year = year; }
        public void SetMonth(int month) { Month = month; }  
        public void SetDay(int day) { Day = day; }
        public void SetHours(int hours) { Hours = hours; }   
        public void SetMinutes(int minutes) { Minutes = minutes; }   

        public int GetYear() { return Year; }
        public int GetMonth() { return Month; }
        public int GetDay() { return Day; }
        public int GetHours() { return Hours; }
        public int GetMinutes() { return Minutes; }
        
        public override string ToString()
        {
            return $"{Day}.{Month}.{Year} {Hours}:{Minutes}";
        }
    }
}