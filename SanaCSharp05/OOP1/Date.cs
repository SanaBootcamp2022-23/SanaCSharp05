using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP1;

namespace OOP1
{
    class Date
    {
        protected uint Year;
        protected byte Month;
        protected byte Day;
        protected byte Hours;
        protected byte Minutes;

        public Date()
        {
            Year = 2023;
            Month = 2;
            Day = 16;
            Hours = 13;
            Minutes = 34;
        }

        public Date(uint Year, byte Month, byte Day)
        {
            this.Year = Year;
            this.Month = Month;
            this.Day = Day;
        }
        public Date(uint Year, byte Month, byte Day, byte Hours, byte Minutes) : this(Year, Month, Day)
        {
            this.Hours = Hours;
            this.Minutes = Minutes;
        }
        public Date(Date CreatedObject)
        {
            Year = CreatedObject.Year;
            Month = CreatedObject.Month;
            Day = CreatedObject.Day;
            Hours = CreatedObject.Hours;
            Minutes = CreatedObject.Minutes;
        }

        public uint year
        {
            get { return Year; }
            set { year = value; }
        }
        public byte month
        {
            get { return Month; }
            set
            {
                if (value > 0 && value <= 12)
                    Month = value;
            }
        }
        public byte day
        {
            get { return Day; }
            set
            {
                if (value > 0 && value <= 12)
                    Day = value;
            }
        }
        public byte hours
        {
            get { return Hours; }
            set
            {
                if (value >= 0 && value < 24)
                    Hours = value;
            }
        }
        public byte minutes
        {
            get { return Minutes; }
            set
            {
                if (value > 0 && value < 60)
                    Minutes = value;
            }
        }

        public void FullDateInfo()
        {
            Console.Write($"{Year}/{Month}/{Day} \t {Hours}:{Minutes}");
        }
    }
}