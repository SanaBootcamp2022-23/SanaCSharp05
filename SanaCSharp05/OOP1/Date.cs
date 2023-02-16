using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Date
    {
        protected int Years { get; set; }
        protected int Months { get; set; }
        protected int Days { get; set; }
        protected int? Hours { get; set; }
        protected int? Minutes { get; set; }

        public Date() 
        {
            Years = 0; 
            Months = 0;
            Days = 0;
            Hours = 0;
            Minutes = 0;
        }

        public Date(int years, int months, int days, int hours, int minutes)
        {
            Years = years;
            Months = months;
            Days = days;
            Hours = hours;
            Minutes = minutes;
        }

        public Date(int years, int months, int days)
        {
            Years = years;
            Months = months;
            Days = days;
        }

        public Date(Date date)
        {
            Years = date.Years;
            Months = date.Months;
            Days = date.Days;
            Hours = date.Hours;
            Minutes = date.Minutes;
        }

        public int GetTotalMinutes()
        {
            if (Hours != null && Minutes != null)
            {
                return (int)(Years * 364 * 24 * 60 + Months * 30 * 24 * 60 + Days * 24 * 60 + Hours * 60 + Minutes);
            }
            return Years * 364 * 24 * 60 + Months * 30 * 24 * 60 + Days * 24 * 60;
        }

        public override string ToString()
        {
            if (Hours != null && Minutes != null)
            {
                return $"{Years}-{Months}-{Days} {Hours}:{Minutes}";
            }
            return $"{Years}-{Months}-{Days}";
        }
    }
}
