namespace OOP1
{
    public class Date
    {
        public const int MINUTES_IN_YEAR = 525600;
        public const int MINUTES_IN_MONTH = 43800;
        public const int MINUTES_IN_DAY = 1440;
        public const int MINUTES_IN_HOUR = 60;
        private int year;
        private int month;
        private int day;
        private int hours;
        private int minutes;
        public int Year
        {
            get { return year; }
            set { if (value > 0) year = value; }
        }
        public int Month
        {
            get { return month; }
            set { if (value > 0 && value <= 12) month = value; }
        }
        public int Day
        {
            get { return day; }
            set { if (value > 0 && value <= 31) day = value; }
        }
        public int Hours
        {
            get { return hours; }
            set { if (value >= 0 && value <= 23) hours = value; }
        }
        public int Minutes
        {
            get { return minutes; }
            set { if (value >= 0 && value <= 59) minutes = value; }
        }
        public Date() { }
        public Date(Date date)
        {
            Year = date.Year;
            Month = date.Month;
            Day = date.Day;
            Hours = date.Hours;
            Minutes = date.Minutes;
        }
        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        public Date(int day, int month, int year, int hours, int minutes) : this(day, month, year)
        {
            Hours = hours;
            Minutes = minutes;
        }
    }
}
