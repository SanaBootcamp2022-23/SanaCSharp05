using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Date
    {
        protected short _minutes;
        protected short _hours;
        protected short _day;
        protected short _month;
        protected short _year;

        public short Minutes
        {
            get { return _minutes;}

            set
            {
                if (value >= 0 && value <= 60)
                    _minutes = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }
        public short Hours
        {
            get { return _hours;}

            set
            {
                if (value >= 0 && value < 24)
                    _hours = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }
        public short Day
        {
            get { return _day; }

            set
            {
                if (value >= 0 && value <= 31)
                    _day = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }
        public short Month
        {
            get { return _month; }

            set
            {
                if (value >= 1 && value <= 12)
                    _month = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }
        public short Year
        {
            get { return _year; }
            set 
            {
                if (value >= DateTime.Today.Year)
                    _year = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }

        public Date()
        {
            Year = (short)DateTime.Today.Year;
            Month = (short)DateTime.Today.Month;
            Day = (short)DateTime.Today.Day;
            Hours = (short)DateTime.Now.Hour;
            Minutes = (short)DateTime.Now.Minute;
        }
        public Date(short minutes)
        {
            Minutes = minutes;
            Hours = (short)DateTime.Now.Hour;
            Day = (short)DateTime.Today.Day;
            Month = (short)DateTime.Today.Month;
            Year = (short)DateTime.Today.Year;
        }
        public Date(short minutes, short hours) : this(minutes)
        {
            Hours = hours;
        }
        public Date(short minutes, short hours, short day) : this(minutes, hours)
        {
            Day = day;
        }
        public Date(short minutes, short hours, short day, short month) : this(minutes, hours, day)
        {
            Month = month;
        }
        public Date(short minutes, short hours, short day, short month, short year) : this(minutes, hours, day, month)
        {
            Year = year;
        }
        public Date (Date obj)
        {
            _year = obj._year;
            _month = obj._month;
            _day = obj._day;
            _hours = obj._hours;
            _minutes = obj._minutes;
        }
    }
}
