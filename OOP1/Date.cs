﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Date
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public Date()
        {
            DateTime now = DateTime.Now;
            Day = now.Day;
            Month = now.Month;
            Year = now.Year;
            Hours = now.Hour;
            Minutes = now.Minute;
        }
        public Date(int day, int month, int year, int hours, int minutes)
        {
            Day = day;
            Month = month;
            Year = year;
            Hours = hours;
            Minutes = minutes;
        }
        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        public Date(int month, int year)
        {
            Month = month;
            Year = year;
        }
        public Date(Date date)
        {
            Day = date.Day;
            Month = date.Month;
            Year = date.Year;
            Hours = date.Hours;
            Minutes = date.Minutes;
        }
    }
}
