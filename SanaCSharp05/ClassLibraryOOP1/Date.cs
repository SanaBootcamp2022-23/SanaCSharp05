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

        public Date(int year, int month, int day) 
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
            set{ Year = value; }
            get{ return Year; }
        }

        public int hours
        {
            set { Hours = value; }
            get { return Hours; }
        }

        public int day
        {
            set { Day = value; }
            get { return Day; }
        }

        public int minutes
        {
            set { Minutes = value; }
            get { return Minutes; }
        }
        public int month
        {
            set { Month = value; }
            get { return Month; }
        }

        public DateTime GetFullDate()
        {
            return new DateTime(this.Year, this.Month, this.Day, this.Hours, this.Minutes, 0);
        }
    }
}
