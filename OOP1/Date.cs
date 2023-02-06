
namespace OOP1
{
    public class Date
    {
        protected int year;
        protected int month;
        protected int day;
        protected int hours;
        protected int minutes;

        public Date()
        {
            year= 0;
            month= 0;
            day= 0;
            hours= 0;
            minutes= 0;
        }
        public Date(int year, int month, int day, int hours, int minutes)
        {
            this.year = year;
            this.month = month;
            this.day = day;
            this.hours = hours;
            this.minutes = minutes;
        }

        public Date(int year, int month, int day) : this(year, month, day, 0, 0)
        { }

        public Date(int hours, int minutes) : this(0, 0, 0, hours, minutes)
        { }

        public Date(Date otherdate)
        {
            this.year = otherdate.year;
            this.month = otherdate.month;
            this.day = otherdate.day;
            this.hours = otherdate.hours;
            this.minutes = otherdate.minutes;
        }

        public int Year
        {
            set
            {
                if (value >= 0)
                    year = value;
            }

            get { return year; }
        }
        public int Month
        {
            set
            {
                if (value >= 1 && value <= 12)
                    month = value;
            }

            get { return month; }
        }
        public int Day
        {
            set
            {
                if (value >= 1 && value <= 31)
                    day = value;
            }
            get { return day; }
        }
        public int Hours
        {
            set
            {
                if (value >= 0 && value <= 23)
                    hours = value;
            }
            get { return hours; }
        }
        public int Minutes
        {
            set
            {
                if (value >= 0 && value <= 59)
                    minutes = value;
            }
            get { return minutes; }
        }
    }
}
