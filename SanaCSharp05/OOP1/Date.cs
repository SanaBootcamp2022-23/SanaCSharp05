using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Date
    {
        public int year;
        protected int Year
        {
            get { return year; }
            set
            {
                year = value;
            }

        }
        protected int month;
        public int Month
        {
            get { return month; }
            set
            {
                month = value;
            }
        }
        protected int day;
        public int Day
        {
            get { return day; }
            set
            {
                day = value;
            }
        }

        protected int hours;
        public int Hours
        {
            get { return hours; }
            set
            {
                hours = value;
            }
        }
        protected int minutes;
        public int Minutes
        {
            get { return minutes; }
            set
            {
                minutes = value;
            }
        }
        public Date(int year, int month, int hours, int day, int minutes)
        {
            this.year = year;
            this.month = month;
            this.hours = hours;
            this.day = day;
            this.minutes = minutes;
        }

        public Date(int day, int year, int month)
        {
            this.day = day;
            this.year = year;
            this.month = month;
        }
        public double DateToMinutes(int day,int month,int hours,int minutes)
        {
            day = day * 1440;
            hours = hours * 60;
            month = month * 43830;
            minutes = minutes + day + hours + month;
            return minutes;
            
        }

        public static implicit operator double(Date? v)
        {
            throw new NotImplementedException();
        }
        public Date(Date obj)
        {
            hours=obj.hours;
            minutes=obj.minutes;
            day=obj.day;
            month=obj.month;
            year=obj.year;
        }
    }
    
    

    
    
}
