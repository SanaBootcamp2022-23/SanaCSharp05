using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Classes.Journey
{
    public class Date
    {
        protected short year = 2023;
        protected byte month = 3;
        protected byte day = 1;
        protected byte hours = 10;
        protected byte minutes = 10;

        public short Year
        {
            get => year;
            set
            {
                if (value >= 2023 && value < 2100)
                    year = value;
            }
        }
        public byte Month
        {
            get => month;
            set
            {
                if (value > 0 && value < 13)
                    month = value;
            }
        }
        public byte Day
        {
            get => day;
            set
            {
                if (value > 0 && value <= CalcLibrary.CountDayInMonth(month, year))
                    day = value;
            }
        }
        public byte Hours
        {
            get => hours;
            set
            {
                if (value >= 0 && value < 24)
                    hours = value;
            }
        }
        public byte Minutes
        {
            get => minutes;
            set
            {
                if (value >= 0 && value < 59)
                    minutes = value;
            }
        }

        public Date() { }
        public Date(short Year, byte Month, byte Day) : this(Year, Month, Day, 10, 10) { }
        public Date(short Year, byte Month, byte Day, byte Hours) : this(Year, Month, Day, Hours, 10) { }
        public Date(short Year, byte Month, byte Day, byte Hours, byte Minutes)
        {
            this.Year = Year;
            this.Month = Month;
            this.Day = Day;
            this.Hours = Hours;
            this.Minutes = Minutes;
        }
        public Date(Date date) : this(date.Year, date.Month, date.Day, date.Hours, date.Minutes) { }

        public override string ToString()
        {
            return $"Year - {Year} \tMonth - {Month} \tDay - {Day} \tHours - {Hours} \tMinutes - {Minutes}";
        }
    }
}
