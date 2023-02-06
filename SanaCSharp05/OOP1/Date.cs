using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Date
    {
        
        private uint year;
        public uint Year {
            get { return year; }
            set {
                if (value > 0)
                    year = value;
                else throw new ArgumentException("error");
            }
        }
        private uint month;
        public uint Month 
        {
            get { return month; } 
            set {
                if (value > 0 && value <= 12) 
                    month = value; 
                else  throw new ArgumentException("error");
            } 
        }
        private uint day;
        public uint Day {
            get { return day; }
            set 
            { 
                if(value >= 1 && value <= 31)
                    day = value;
                else throw new ArgumentException("error");
            }
        }
        private uint hour;   
        public uint Hours {
            get { return hour; }
            set
            {
                if(value <= 24 && value >=0) hour = value;
                else throw new ArgumentException("error");
            } 
        }
        private uint minute;    
        public uint Minutes {
            get { return minute; }
            set {
                if(value <= 60 && value >=0)
                    minute = value;
                else throw new ArgumentException("error");
            } 
        }

        public Date()
        {
           
        }
        public Date(uint years, uint months, uint days, uint hours, uint minutes)
        {
            Year = years;
            Month = months;  
            Day = days;
            Hours = hours;
            Minutes = minutes;           
        }
        public Date(uint years, uint months, uint days)
        {
            Year = years;
            Month = months;
            Day = days;   
        }
        public Date(Date date)
        {
            Year = date.Year;
            Month = date.Month;
            Day = date.Day;
            Hours = date.Hours;
            Minutes = date.Minutes;
        }
    }
}
