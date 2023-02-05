namespace OOP1
{
    class Date
    {
        protected int Year;
        protected int Month;
        protected int Day;
        protected int Hours;
        protected int Minutes;

        public Date()
        {
            Year = DateTime.Now.Year;
            Month = DateTime.Now.Month;
            Day = DateTime.Now.Day;
            Hours = DateTime.Now.Hour;
            Minutes = DateTime.Now.Minute;
        }

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
            Hours = DateTime.Now.Hour;
            Minutes = DateTime.Now.Minute;
        }

        public Date(int hours, int minutes)
        {
            Year = DateTime.Now.Year;
            Month = DateTime.Now.Month;
            Day = DateTime.Now.Day;
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

        public void setYear(int year)
        {
            if (year > 0)
                Year = year;
        }

        public void setMonth(int month)
        {
            if (month > 0)
                Month = month;
        }

        public void setDay(int day)
        {
            if (day > 0)
                Day = day;
        }

        public void setHours(int hours)
        {
            if (hours >= 0 && hours < 24)
            {
                Hours = hours;
            }

            if (hours == 24)
            {
                Hours = 0;
            }
        }

        public void setMinutes(int minutes)
        {
            if (minutes >= 0 && minutes < 60)
            {
                Minutes = minutes;
            }

            if (minutes == 60)
            {
                minutes = 0;
            }
        }

        public int getYear()
        {
            return Year;
        }

        public int getMonth()
        {
            return Month;
        }

        public int getDay()
        {
            return Day;
        }

        public int getHours()
        {
            return Hours;
        }

        public int getMinutes()
        {
            return Minutes;
        }

    }
}