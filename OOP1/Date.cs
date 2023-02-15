using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Date
    {
        protected uint year;
        protected uint month;
        protected uint day;
        protected uint hours;
        protected uint minutes;
        public Date()
        {
            year = 2023;
            month = 1;
            day = 1;
            hours = 0;
            minutes = 0;
        }
        public Date(uint Year, uint Month, uint Day, uint Hours, uint Minutes)
        {
            if (IsYearValid(Year))
                year = Year;
            else
                throw new Exception("Year is incorrect!");
            if (IsMonthValid(Month))
                month = Month;
            else
                throw new Exception("Month is incorrect!");
            if (IsDayValid(Day))
                day = Day;
            else
                throw new Exception("Day is incorrect!");
            if (IsHoursValid(Hours))
                hours = Hours;
            else
                throw new Exception("Hours is incorrect!");
            if (IsMinutesValid(Minutes))
                minutes = Minutes;
            else
                throw new Exception("Minutes is incorrect!");
        }
        public Date(uint Year, uint Month, uint Day)
        {
            if (IsYearValid(Year))
                year = Year;
            else
                throw new Exception("Year is incorrect!");
            if (IsMonthValid(Month))
                month = Month;
            else
                throw new Exception("Month is incorrect!");
            if (IsDayValid(Day))
                day = Day;
            else
                throw new Exception("Day is incorrect!");
            hours = 0;
            minutes = 0;
        }
        public Date(uint Hours, uint Minutes)
        {
            year = 2023;
            month = 1;
            day = 1;
            if (IsHoursValid(Hours))
                hours = Hours;
            else
                throw new Exception("Hours is incorrect!");
            if (IsMinutesValid(Minutes))
                minutes = Minutes;
            else
                throw new Exception("Minutes is incorrect!");
        }
        public Date(Date obj) : this(obj.year, obj.month, obj.day, obj.hours, obj.minutes)
        {    
        }
        private bool IsYearValid(uint Year)
        {
            if (Year >= 2023 && Year <= 2033)
                return true;
            return false;
        }
        private bool IsMonthValid(uint Month)
        {
            if (Month >= 1 && Month <= 12)
                return true;
            return false;
        }
        private bool IsDayValid(uint Day)
        {
            if (Day >= 1 && Day <= 31)//The dependence of the number of days on the month and year is not taken into account
                return true;
            return false;
        }
        private bool IsHoursValid(uint Hours)
        {
            if (Hours >= 0 && Hours <= 23)
                return true;
            return false;
        }
        private bool IsMinutesValid(uint Minutes)
        {
            if (Minutes >= 0 && Minutes <= 59)
                return true;
            return false;
        }
        public string GetFullDate()
        {
            return $"{year}, {month}, {day}, {hours}, {minutes}";
        }
        public uint Year
        {
            set
            {
                if (IsYearValid(Year))
                    year = value;
            }
            get
            {
                return year;
            }
        }
        public uint Month
        {
            set
            {
                if (IsYearValid(Month))
                    month = value;
            }
            get
            {
                return month;
            }
        }
        public uint Day
        {
            set
            {
                if (IsYearValid(Day))
                    day = value;
            }
            get
            {
                return day;
            }
        }
        public uint Hours
        {
            set
            {
                if (IsYearValid(Hours))
                    hours = value;
            }
            get
            {
                return hours;
            }
        }
        public uint Minutes
        {
            set
            {
                if (IsYearValid(Minutes))
                    minutes = value;
            }
            get
            {
                return minutes;
            }
        }
    }
}
