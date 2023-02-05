using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Date
    {
        protected int minute;
        protected int hour;
        protected int day;
        protected int month;
        protected int year;
        public int timeMinute
        {
            set {
                if (value >= 0 && value <= 60) minute = value;
            }
            get {
                return minute;
            }
        }
        public int timeHour
        {
            set {
                if (value >= 0 && value <= 23) hour = value;
            }
            get {
                return hour;
            }
        }
        public int timeMonth
        {
            set {
                if (value >= 1 && value <= 12)
                    month = value;
            }
            get
            {
                return month;
            }
        }
        public int timeYear
        {
            set {
                if (value >= 1970 && value <= 2038)
                    year = value;
            }
            get {
                return year;
            }
        }
        public int timeDay
        {
            set
            {
                if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                {
                    if (value >= 1 && value <= 31)
                        day = value;
                }
                else if (month == 2)
                {
                    if (value >= 1 && value <= 28)
                    {
                        day = value;
                    }
                }
                else if (year % 4 == 0)
                {
                    if (month == 2)
                    {
                        if (value >= 1 && value <= 29)
                        {
                            day = value;
                        }
                    }
                }
                else if (month == 4 || month == 6 || month == 9 || month == 11) {
                    if (value >= 1 && value <= 30)
                    {
                        day = value;
                    }
                }
            }
            get {
                return day;
            }
        }
        public Date()
        {
            timeYear = 2019;
            timeMonth = 12;
            timeDay = 23;
            timeHour = 19;
            timeMinute = 15;
        }
        public Date(int year, int month, int day, int hour, int minute)
        {
            timeYear = year;
            timeMonth = month;
            timeDay = day;
            timeHour = hour;
            timeMinute = minute;
        }
        public Date(Date obj)
        {
            timeYear = obj.timeYear;
            timeMonth = obj.timeMonth;
            timeDay = obj.timeDay;
            timeHour = obj.timeHour;
            timeMinute = obj.timeMinute;
        }
        
    }
}
