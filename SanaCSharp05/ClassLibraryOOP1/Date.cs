using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryOOP1
{
    public class Date
    {
        protected int Year;
        protected int Month;
        protected int Day;
        protected int Hours;
        protected int Minutes;

        public Date()
        {
           this.Year = DateTime.Now.Year;
           this.Month = DateTime.Now.Month;
           this.Day = DateTime.Now.Day;
           this.Hours = DateTime.Now.Hour;
           this.Minutes = DateTime.Now.Minute;
        }

        public Date(int year, int month, int day, int hours, int minutes)
        {
            this.Year = year;
            this.Month = month;
            this.Day = day;
            this.Hours = hours;
            this.Minutes = minutes;
        }

        public Date(int day, int month, int year) 
        {
            this.Year = year;
            this.Month = month;
            this.Day = day;
            this.Hours = DateTime.Now.Hour;
            this.Minutes = DateTime.Now.Minute;
        }

        public Date(Date previousDate)
        {
            this.Year = previousDate.Year;
            this.Month = previousDate.Month;
            this.Day = previousDate.Day; ;
            this.Hours = previousDate.Hours; ;
            this.Minutes = previousDate.Minutes;
        }

        public int year
        {
            set{ if(value >= 2023) Year = value; }
            get{ return Year; }
        }

        public int hours
        {
            set { if (value >= 0 && value <= 24) Hours = value; }
            get { return Hours; }
        }

        public int day
        {
            set { if(value >= 1 && value <= 31) Day = value; }
            get { return Day; }
        }

        public int minutes
        {
            set { if(value >= 0 && value <= 59) Minutes = value; }
            get { return Minutes; }
        }
        public int month
        {
            set { if(value >= 1 && value <= 12) Month = value; }
            get { return Month; }
        }

        public DateTime GetFullDate()
        {
            return new DateTime(this.Year, this.Month, this.Day, this.Hours, this.Minutes, 0);
        }
    }
}
