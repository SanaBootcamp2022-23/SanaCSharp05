using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Date
    {
        protected int Year = 1970;
        protected int Month = 12;
        protected int Day = 29;
        protected int Hour = 23;
        protected int Minute = 59;

        //Конструктор по замовчуванню
        public Date() { }
        
        //Set та Get 
        public int Years
        {
            get { return Year; }
            set { if (value > 2022) Year = value; }
        }
        public int Months
        {
            get { return Month; }
            set { if (value > 0 && value <= 12) Month = value; }
        }
        public int Days
        {
            get { return Day; }
            set { if (value > 0 && value <= 31) Day = value; }
        }
        public int Hours
        {
            get { return Hour; }
            set { if (value >= 0 && value <= 23) Hour = value; }
        }
        public int Minutes
        {
            get { return Minute; }
            set { if (value >= 0 && value <= 59) Minute = value; }
        }
        
        //Конструктори з параметрами
        public Date(int year, int month, int day, int hours, int minutes)
        {
            Year = year;
            Month = month;
            Day = day;
            Hour = hours;
            Minute = minutes;       
        }
        public Date(int month, int day, int hours, int minutes)
        {
            Month = month;
            Day = day;
            Hour = hours;
            Minute = minutes;
        }
        public Date(int hours, int minutes)
        {
            Hour = hours;
            Minute = minutes;
        }
        
        //Конструктор копіювання
        public Date(Date copied) : this(copied.Year, copied.Month, copied.Day, copied.Hour, copied.Minute)
        {

        }
    }
}
