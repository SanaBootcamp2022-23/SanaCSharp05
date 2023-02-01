using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Date
    {
        private int _year;
        private int _month;
        private int _day;
        private int _hour;
        private int _minute;
        
        public Date(int Year, int Month, int Day)
        {
            _year = Year;
            _month = Month;
            _day = Day;
        }
        public Date() { }
        public Date(int Year, int Month, int Day, int Hour, int Minute)
        {
            _year = Year;
            _month = Month;
            _day = Day;
            _hour = Hour;
            _minute = Minute;
        }
        public Date(Date Copy)
        {
            Copy._day = GetDay;
            Copy._hour = GetHour;
            Copy._minute = GetMinute;
            Copy._year = GetYear;
            Copy._month = GetMonth;
        }
        public int Total()
        {
            int total = 0;
            total += GetMinute+GetHour*60 + GetDay * 24 * 60 + GetMonth * 31 * 24 * 60 + GetYear * 12 * 31 * 24 * 60;
            
            return total;
        }
        
        public int GetDay
        {
            get
            {
                return _day;
            }
            set
            {
                if (value > 0)
                {
                    _day = value;
                }
            }
        }
        public int GetMonth
        {
            get
            {
                return _month;
            }
            set
            {
                if (value > 0)
                {
                    _month = value;
                }
            }

        }
        public int GetYear
        {
            get
            {
                return _year;
            }
            set
            {
                if (value > 1111)
                {
                    _month = value;
                }
            }
        }
        public int GetHour
        {
            get
            {
                return _hour;
            }
            set
            {
                if (value < 60)
                {
                    _hour = value;
                }
            }
        }
        public int GetMinute
        {
            get
            {
                return _minute;
            }
            set
            {
                if (value < 60)
                {
                    _minute = value;
                }
            }
        }
    }
}
