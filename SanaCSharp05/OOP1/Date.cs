namespace OOP1
{
    public class Date
    {
        protected int Year;
        protected int Day;
        protected int Month;
        protected int Hour;
        protected int Minute;
        protected int Second;

        public int year
        {
            get { return Year; }
            set { if (value > 0) Year = value; }
        }

        public int day
        {
            get { return Day; }
            set { if (value > 0) Day = value; }
        }
        public int month
        {
            get { return Month; }
            set { if (value > 0) Month = value; }
        }
        public int hours
        {
            get { return Hour; }
            set { if (value > 0) Hour = value; }
        }
        public int minutes
        {
            get { return Minute; }
            set { if (value > 0) Minute = value; }
        }
        public int seconds
        {
            get { return Second; }
            set { if (value > 0) Second = value; }
        }

        protected static DateTime DefaultDate = DateTime.Now;

        public Date(int year,  int day, int month, int hour, int minute, int second)
        {
            Year = year;
            Day = day;
            Month = month;
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        public Date():this(DefaultDate.Year, DefaultDate.Day, DefaultDate.Month, DefaultDate.Hour, DefaultDate.Minute, DefaultDate.Second) {}
        public Date(DateTime date):this(date.Year, date.Day, date.Month, date.Hour, date.Minute, date.Second) {}
        public Date(int year) : this(year,1,1,1,1,1) { }
    }
}
