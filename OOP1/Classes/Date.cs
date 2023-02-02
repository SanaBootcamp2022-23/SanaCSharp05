using System.ComponentModel.DataAnnotations;

namespace OOP1
{
    public class DateData
    {
        [Range(0001, 9999)] public int Year { get; }
        [Range(1, 12)] public int Month { get; }
        [Range(1, 31)] public int Day { get; }
        [Range(0, 24)] public int Hour { get; }
        [Range(0, 59)] public int Minute { get; }
        [Range(0, 59)] public int Second { get; }
        public static DateTime Now => DateTime.Now;

        public DateData() :
            this(Now.Hour, Now.Month, Now.Day, Now.Hour, Now.Minute, Now.Second)
        { }

        public DateData(int year, int month, int day, int hours, int minutes, int seconds)
        {
            Year = year;
            Month = month;
            Day = day;
            Hour = hours;
            Minute = minutes;
            Second = seconds;
        }

        public DateData(DateData clone)
            : this(clone.Year, clone.Month, clone.Day, clone.Hour, clone.Minute, clone.Second)
        { }
    }

    public class Date
    {
        public DateData DateData { get; }

        public Date()
        {
            DateData = new DateData();
        }

        public Date(int Year, int Month, int Day, int Hours, int Minutes, int Seconds)
        {
            DateData = new DateData(Year, Month, Day, Hours, Minutes, Seconds);
        }
        public Date(DateTime date) 
            : this(date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second)
        { }

        public Date(Date clone)
        {
            DateData = clone.DateData;
        }

        public int GetYear { get => DateData.Year; }
        public int GetMonth { get => DateData.Month; }
        public int GetDay { get => DateData.Day; }
        public int GetHours { get => DateData.Hour; }
        public int GetMinutes { get => DateData.Minute; }
        public int GetSeconds { get => DateData.Second; }

        public override string ToString()
        {
            return DateTime.Parse($"{GetDay}.{GetMonth}.{GetYear} {GetHours}:{GetMinutes}:{GetSeconds}").ToString();
        }
    }

    public static class DateParser
    {
        public static DateTime ToDateTime(this Date date)
        {
            return DateTime.Parse(date.ToString());
        }
    }
}