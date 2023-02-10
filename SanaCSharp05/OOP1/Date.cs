using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Date
    {
        private int Year=2023;
        private int Month=1;
        private int Day=1;
        private int Hour = 1;
        private int Minute=1;

        public Date(int year, int month, int day, int hour, int minute)
        {
            if (year <= 2023 && year > 0) { Year = year; }
            if (month > 0 && month <= 12) { Month = month; }
            if (day > 0 && day < 32) { Day = day; }
            if (hour >= 0 && hour < 24) { Hour = hour; }
            if (minute >=0 && minute < 60){ Minute = minute; }
        }
        public Date(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }
        public Date()
        {

        }
        public Date(Date date)
        {
            Year=date.Year;
            Month=date.Month;
            Day=date.Day;
            Hour=date.Hour;
            Minute=date.Minute;
        }

        public int GetYear() { return Year;}
        public int GetMonth() { return Month; }
        public int GetDay() { return Day; }
        public int GetHour() { return Hour; }
        public int GetMinute() { return Minute; }

        public void SetYear(int year)
        {
            if (year > 0 && year < 2023) {Year = year;}
        }
        public void SetMonth(int month)
        {
            if (month > 0 && month <= 12) {Month = month;}
        }
        public void SetDay(int day)
        {
            if (day > 0 && day <= 31) { Day = day; }
        }
        public void SetHour(int hour)
        {
            if (hour >= 0 && hour <= 24) { Hour = hour; }
        }
        public void SetMinute(int minute)
        {
            if (minute >= 0 && minute < 60) { Minute = minute; }
        }


    }
}
