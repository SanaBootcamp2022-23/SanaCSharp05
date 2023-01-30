namespace OOP1
{
    internal class Date
    {
        private int _year = 0;
        private int _month = 1;
        private int _day = 1;
        private int _hours = 0 ;
        private int _minutes = 0;

        public int Year
        {
            get { return _year; }
            set
            {
                if (value >= 0)
                    _year = value;
            }
        }

        public int Month
        {
            get { return _month; }
            set
            {
                if (value >= 1 && value <= 12)
                    _month = value;
            }
        }

        public int Day
        {
            get { return _day; }
            set
            {
                if (value >= 1 && value <= 31)
                    _day = value;
            }
        }

        public int Hours
        {
            get { return _hours; }
            set
            {
                if (value >= 0 && value < 24)
                    _hours = value;
            }
        }

        public int Minutes
        {
            get { return _minutes; }
            set
            {
                if (value >= 0 && value < 60)
                    _minutes = value;
            }
        }

        public Date() { }

        public Date(int year, int month, int day, int hours, int minutes)
        {
            Year = year;
            Month = month;
            Day = day;
            Hours = hours;
            Minutes = minutes;
        }

        public Date(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }

        public Date(int hours, int minutes)
        {
            Hours = hours;
            Minutes = minutes;
        }

        public Date(Date date)
        {
            Year = date.Year;
            Month = date.Month;
            Day = date.Day;
            Hours = date.Hours;
            Minutes = date.Minutes;
        }

        public Date Copy()
        {
            return new(this);
        }
    }
}
