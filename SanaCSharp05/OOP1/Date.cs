using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP1
{
    public class Date
    {
        private int _year;
        private int _month;
        private int _day;
        private int _hours;
        private int _minutes;


        public  Date()
        {
            Year = 2000;
            Month = 1;
            Day = 1;
            Hours = 0;
            Minutes = 0;
        }
      public  Date (int year, int month, int day, int hours, int minutes)
        {
            Year = year;
            Month = month;
            Day = day;
            Hours = hours;
            Minutes = minutes;
            
        }
       public Date(Date CopyDate)
        {
            Year = CopyDate.Year;    
            Month = CopyDate.Month;
            Day = CopyDate.Day;
            Hours = CopyDate.Hours;
            Minutes = CopyDate.Minutes;

        }

        public void PrintDate()
        {
            Console.WriteLine("Year: " + Year);
            Console.WriteLine("Month: " + Month);
            Console.WriteLine("Day: " + Day);
            Console.WriteLine("Hours: " + Hours);
            Console.WriteLine("Minutes: " + Minutes);
        }

        public int Year
        {
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Неправильне введення");
                }
                
                _year = value;
            }
            get
            { 
            
                return _year;
            }

        }
        public int Month
        {
            set
            {
                if (value < 1||value>12)
                {
                    throw new ArgumentException("Неправильне введення");
                }
                _month = value;
            }
            get
            {
                return _month;
            }
        }
        public int Day
        {
            set
            {
                if (value < 1||value>31)
                {
                    throw new ArgumentException("Неправильне введення");
                }
                _day = value;
            }
            get
            {
                return _day;
            }

        }
        public int Hours
        {
            set
            {
                if (value < 0||value >24)
                {
                    throw new ArgumentException("Неправильне введення");
                }
                _hours = value;
            }
            get
            {
                return _hours;
            }
        }
        public int Minutes
        {
            set
            {
                if (value < 0||value>60)
                {
                    throw new ArgumentException("Неправильне введення");
                }
                _minutes = value;
            }
            get
            {
                return _minutes;
            }
        }
    }
}
