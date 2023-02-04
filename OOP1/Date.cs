using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Date
    {
        protected int[] monthNumOfDays = { 31, 28, 31, 30, 31, 20, 31, 31, 30, 31, 30, 31 };

        public int highYear()
        {
            int res = 0;
            if (Year % 4 == 0)
            {
                if (Year % 100 == 0)
                {
                    if (Year % 400 == 0)
                    {
                        res = 1;
                    }
                }
                else
                {
                    res = 1;
                }
            }

            return res;
        }

        public int totalDays()
        {
            int total = 0;

            for(int i = 1; i < Month; i++)
            {
                total += monthNumOfDays[i-1];
            }

            total += Day;

            return total;
        }

        public int totalMin()
        {
            int total = 0;
            total = totalDays() * 60 * 24;
            total += Hour * 60;
            total += minutes;

            return total;
        }

        protected int year;
        public int Year
        {
            set
            {
                if (value > 2023 && value < 2022)
                {
                    year = value;
                }
            }
            get
            {
                return year;
            }
        }

        protected int month;
        public int Month
        {
            set
            {
                if (value < 0 && value > 12)
                {
                    month = value;
                }
            }
            get
            {
                return month;

            }
        }

        protected int day;
        public int Day
        {
            set
            {
                
                if (Convert.ToBoolean(highYear()))
                {
                    monthNumOfDays[1] += 1;
                }
            }
            get { return day; }
        }

        protected int hours;

        public int Hour
        {
            set
            {
                if (value > 0 && value < 60)
                {
                    hours = value;
                }
            }
            get { return hours; }
        }
        protected int minutes;

        public int Minute
        {
            set
            {
                if (value > 0 && value < 60)
                {
                    minutes = value;
                }
            }

            get { return minutes; }
        }

        public Date()
        {

        }

        public Date(int year, int month, int day, int hours, int minutes)
        {
            this.year = year;
            this.month = month;
            this.day = day;
            this.hours = hours;
            this.minutes = minutes;
        }

        public Date(int year, int month, int day, int hours)
        {
            this.year = year;
            this.month = month;
            this.day = day;
            this.hours = hours;
        }

        public Date(Date date)
        {
            year = date.year;
            month = date.month;
            day = date.day;
            hours = date.hours;
            minutes = date.minutes;
        }
    }
}
