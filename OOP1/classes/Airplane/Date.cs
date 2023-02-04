namespace OOP1.classes.Airplane
{
    public class Date
    {
        protected int Year;
        public int year
        {
            get { return Year; }
            set
            {
                if (value > 0)
                {
                    Year = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("year");
                }
            }
        }

        protected int Month;
        public int month
        {
            get { return Month; }
            set
            {
                if (month < 1 || month > 12)
                {
                    throw new ArgumentOutOfRangeException("month");
                }
                else
                {
                    Month = value;
                }
            }
        }

        protected int Day;
        public int day
        {
            get { return Day; }
            set
            {
                if (day < 1 || day > 31)
                {
                    throw new ArgumentOutOfRangeException("day");
                }
                else
                {
                    Day = value;
                }
            }
        }

        protected int Hours;
        public int hours
        {
            get { return Hours; }
            set
            {
                if (hours < 1 || hours > 23)
                {
                    throw new ArgumentOutOfRangeException("hours");
                }
                else
                {
                    Hours = value;
                }
            }
        }

        protected int Minutes;
        public int minutes
        {
            get { return Minutes; }
            set
            {
                if (minutes < 1 || minutes > 59)
                {
                    throw new ArgumentOutOfRangeException("minutes");
                }
                else
                {
                    Minutes = value;
                }
            }
        }


        //default constructor
        public Date()
        {
            Year = DateTime.Now.Year;
            Month = DateTime.Now.Month;
            Day = DateTime.Now.Day;
            Hours = DateTime.Now.Hour;
            Minutes = DateTime.Now.Minute;
        }
        //parameterized constructor
        public Date(int year, int month, int day, int hours, int minutes)
        {
            if (year < 0)
            {
                throw new ArgumentOutOfRangeException("year");
            }
            Year = year;

            if (month < 1 || month > 12)
            {
                throw new ArgumentOutOfRangeException("month");
            }
            Month = month;

            if (day < 1 || day > 31)
            {
                throw new ArgumentOutOfRangeException("day");
            }
            Day = day;

            if (hours < 1 || hours > 23)
            {
                throw new ArgumentOutOfRangeException("hours");
            }
            Hours = hours;

            if (minutes < 1 || minutes > 59)
            {
                throw new ArgumentOutOfRangeException("minutes");
            }
            Minutes = minutes;
        }
        //parameterized constructor 2
        public Date(int day, int hours)
        {
            Year = DateTime.Now.Year;
            Month = DateTime.Now.Month;

            if (day < 1 || day > 31)
            {
                throw new ArgumentOutOfRangeException("day");
            }
            Day = day;

            if (hours < 1 || hours > 23)
            {
                throw new ArgumentOutOfRangeException("hours");
            }
            Hours = hours;
        }

        //copy constructor
        public Date(DateTime date)
        {
            Year = date.Year;
            Month = date.Month;
            Day = date.Day;
            Hours = date.Hour;
            Minutes = date.Minute;
        }

        public bool IsEarlier(Date date)
        {
            DateTime date1 = new DateTime(Year, Month, Day, Hours, Minutes, 0);
            DateTime date2 = new DateTime(date.Year, date.Month, date.Day, date.Hours, date.Minutes, 0);
            TimeSpan ts = date2 - date1;
            return ts.TotalMinutes < 0;
        }
    }
}