using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Date
    {
        private int _year = 2000;
        private int _month = 1;
        private int _day = 1;
        private int _hours = 0;
        private int _minutes = 0;

        //властивості
        public int Year
        {
            set
            {
                if (value >= 0)
                    _year = value;
            }
            get { return _year; }
        }
        public int Month
        {
            set
            {
                if (value >= 1 && value <= 12)
                    _month = value;
            }
            get { return _month; }
        }
        public int Day
        {
            set
            {
                if (value >= 1 && value <= 31)
                    _day = value;
            }
            get { return _day; }
        }
        public int Hours
        {
            set
            {
                if (value >= 0 && value < 24)
                    _hours = value;
            }
            get { return _hours; }
        }
        public int Minutes
        {
            set
            {
                if (value >= 0 && value < 60)
                    _minutes = value;
            }
            get { return _minutes; }
        }

        //по замовчуванню
        public Date() { }
        //конструктори з параметрами
        public Date(int year, int month)
        {
            Year = year;
            Month = month;
        }
        public Date(int day, int hours, int minutes)
        {
            Day = day;
            Hours = hours;
            Minutes = minutes;
        }
        public Date(int year, int month, int day, int hours, int minutes)
        {
            Year = year;
            Month = month;
            Day = day;
            Hours = hours;
            Minutes = minutes;
        }
        //конструктор копіювання
        public Date(Date date)
        {
            Year = date.Year;
            Month = date.Month;
            Day = date.Day;
            Hours = date.Hours;
            Minutes = date.Minutes;
        }
        public Date Copy()
        {
            return new(this);
        }

        //сумарний час подорожі у хвилинах
        public uint AllTime()
        {
            uint all = (uint)Minutes;
            all += (uint)Hours * 60;
            all += (uint)Day * 24 * 60;
            all += (uint)Month * 31 * 24 * 60;
            all += (uint)Year * 12 * 31 * 24 * 60;
            return all;
        }
        public override string ToString()
        {
            return $"{Year}.{Month}.{Day} {Hours}:{Minutes}";
        }
    }
}
