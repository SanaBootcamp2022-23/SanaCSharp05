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

        public void SetYear(int year)
        {
            if (year <= 2000)
                year = 2000;

            Year = year;
        }
        public void SetMonth(int month)
        {
            if (month < 1 || month > 12)
                month = 1;

            Month = month;
        }
        public void SetDay(int day) 
        {
            if (day < 1 || day > DateTime.DaysInMonth(Year, Month))
                day = 1;

            Day = day;
        }
        public void SetHours(int hours)
        {
            if(hours < 0 || hours > 24)
                hours = 0;

            Hours = hours;
        }
        public void SetMinutes(int minutes)
        {
            if(minutes < 0 || minutes > 60)
                minutes = 0;

            Minutes = minutes;
        }
        public int GetYear() => Year;
        public int GetMonth() => Month;
        public int GetDay() => Day;
        public int GetHours() => Hours;
        public int GetMinutes() => Minutes;
    }
}
