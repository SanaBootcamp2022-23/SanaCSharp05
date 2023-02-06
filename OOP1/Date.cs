using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Date
    {
        private int _year = 0;
        private int _month = 0;
        private int _day = 0;
        private int _hours = 0;
        private int _minutes = 0;

        public Date()
        {

        }
        public Date(int year, int month, int day, int hours, int minutes)
        {
            _year = year;
            _month = month;
            _day = day;
            _hours = hours;
            _minutes = minutes;
        }
        public Date(int year, int month)
        {
            _year = year;
            _month = month;
        }
        public Date(Date date)
        {
            _year = date._year;
            _month = date._month;
            _day = date._day;
            _hours = date._hours;
            _minutes = date._minutes;    
        }
        

        public int Year
        {
            get => _year;
            set
            {
                if (value > 0 && value < 3000)
                {
                    _year = value;
                }
            }
        }
        public int Month
        {
            get => _month;
            set
            {
                if (value > 0 && value <= 12)
                {
                    _month = value;
                }
            }
        }
        public int Day
        {
            get => _day;
            set
            {
                if (value > 0 && value < 31)
                {
                    _day = value;
                }
            }
        }
        public int Hours
        {
            get => _hours;
            set
            {
                if (value > 0 && value <= 24)
                {
                    _hours = value;
                }
            }
        }
        public int Minutes
        {
            get => _minutes;
            set
            {
                if (value > 0 && value < 3000)
                {
                    _minutes = value;
                }
            }
        }
    }
}
