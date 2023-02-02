using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Date
    {
       public int Year;
        public int Month;
        public int Day;
        public int Hours;
        public int Minutes;
        //I named it "public" because I cant't use it in the "Airplane" class when I wanted to get total time

        public Date()
        {
            Year = DateTime.Now.Year;
            Month = DateTime.Now.Month;
            Day = DateTime.Now.Day;
            Hours = DateTime.Now.Hour;
            Minutes = DateTime.Now.Minute;
        }

        public Date(int year)
        {
            Year = year;
        }
        public Date(int year, int month)
        {
            Year = year;
            Month = month;
        }
        public Date(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }
        public Date(int year, int month, int day, int hours)
        {
            Year = year;
            Month = month;
            Day = day;
            Hours = hours;
        }
        public Date(int year, int month, int day, int hours, int minutes)
        {
            this.Year = year;
            this.Month = month;
            this.Day = day;
            this.Hours = hours;
            this.Minutes = minutes;
        }
        public Date(Date obj)
        {
            this.Year = obj.Year;
            this.Month = obj.Month;
            this.Day = obj.Day;
            this.Hours = obj.Hours;
            this.Minutes = obj.Minutes;
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
            if (year > 0 && year <= 2023)
            {
                Year = year;
            }
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
        public DateTime TotalTime()
        {
            return new DateTime(this.Year, this.Month, this.Day, this.Hours, this.Minutes, 0);
        }
    }
    }

       
