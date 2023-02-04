using System;

namespace ClassLibrary05
{
    public class Date
    {
        protected int Year { get; set; }
        protected int Month { get; set; }
        protected int Day { get; set; }
        protected int Hours { get; set; }
        protected int Minutes { get; set; }

        public Date(Date PrevDate)
        {
            Year = PrevDate.Year;
            Month = PrevDate.Month;
            Day = PrevDate.Day;
            Hours = PrevDate.Hours;
            Minutes = PrevDate.Minutes;
        }

        public Date()
        {
            Year = DateTime.Now.Year;
            Month = DateTime.Now.Month;
            Day = DateTime.Now.Day;
        }

        public Date(int year, int month, int day, int hours, int minutes)
        {
            Year = year;
            Month = month;
            Day = day;
            Hours = hours;
            Minutes = minutes;
        }
    }
}
