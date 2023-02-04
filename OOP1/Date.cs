namespace OOP1;

public class Date
{
    protected int _year;
    public int Year
    {
        get { return _year; }
        set
        {
            if (value < 1)
            {
                throw new ArgumentException("Рік не може бути менше 1.");
            }
            _year = value;
        }
    }

    protected int _month;
    public int Month
    {
        get { return _month; }
        set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException("Місяць повинен бути лише від 1 до 12");
            }
            _month = value;
        }
    }

    protected int _day;
    public int Day
    {
        get { return _day; }
        set
        {
            if (value < 1 || value > 31)
            {
                throw new ArgumentException("День може бути від 1 до 31");
            }
            _day = value;
        }
    }

    protected int _hours;
    public int Hours
    {
        get { return _hours; }
        set
        {
            if (value < 0 || value > 23)
            {
                throw new ArgumentException("Години можуть бути лише від 0 до 23");
            }
            _hours = value;
        }
    }

    protected int _minutes;
    public int Minutes
    {
        get { return _minutes; }
        set
        {
            if (value < 0 || value > 59)
            {
                throw new ArgumentException("Хвилини повинні бути від 0 до 59");
            }
            _minutes = value;
        }
    }

    public Date()
    {
        Year = 1;
        Month = 1;
        Day = 1;
    }
    public Date(int year, int month, int day)
    {
        Year = year;
        Month = month;
        Day = day;
    }

    public Date(int year, int month, int day, int hours, int minutes)
    {
        Year = year;
        Month = month;
        Day = day;
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
    public static bool operator <(Date d1, Date d2)
    {
        if (d1.Year < d2.Year) 
            return true;
        if (d1.Year == d2.Year && d1.Month < d2.Month) 
            return true;
        if (d1.Year == d2.Year && d1.Month == d2.Month && d1.Day < d2.Day) 
            return true;
        return false;
    }
    public static bool operator >(Date date1, Date date2)
    {
        if (date1.Year > date2.Year) 
            return true;
        if (date1.Year == date2.Year && date1.Month > date2.Month) 
            return true;
        if (date1.Year == date2.Year && date1.Month == date2.Month && date1.Day > date2.Day) 
            return true;
        return false;
    }
    public override string ToString()
    {
        return $"{Year}-{Month}-{Day}";
    }
}
