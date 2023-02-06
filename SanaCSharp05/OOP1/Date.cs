namespace OOP1
{
    public class Date
    {
        private int[] DaysUntilMonth = new int[] { 0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 334 };

        private int year;
        private int month;
        private int day;
        private int hours;
        private int minutes;

        public int Year { get => year; init => year = value; }
        public int Month { get => month; init => month = value; }
        public int Day { get => day; init => day = value; }
        public int Hours { get => hours; init => hours = value; }
        public int Minutes { get => minutes; init =>  minutes = value; }

        public Date()
        {
            Year = 1970;
            Month = 1;
            Day = 1;
            Hours = 0;
            Minutes = 0;
        }

        public Date(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }

        public Date(int year, int month, int day, int hours, int minutes) : this(year, month, day)
        {
            Hours = hours;
            Minutes = minutes;
        }

        public Date(Date obj)
        {
            Year = obj.Year;
            Month = obj.Month;
            Day = obj.Day;
            Hours = obj.Hours;
            Minutes = obj.Minutes;
        }

        private bool IsLeapYear() => Year % 400 == 0 || (Year % 4 == 0 && Year % 100 != 0);

        private int GetExtraDaysForLeapYears()
        {
            int leapYearsBefore = Year / 4 - Year / 100 + Year / 400;
            return Month > 2 && this.IsLeapYear() ? leapYearsBefore + 1 : leapYearsBefore;
        }

        public long ToDays() => (Year - 1) * 365 + GetExtraDaysForLeapYears() + DaysUntilMonth[Month - 1] + Day - 1;

        public long ToHours() => ToDays() * 24 + Hours;

        public long ToMinutes() => ToHours() * 60 + Minutes;

        public bool IsDateEqual(Date date)
            => date.Year == Year && date.Month == Month && date.Day == Day;
    }
}
