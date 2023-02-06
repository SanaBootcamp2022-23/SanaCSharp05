namespace OOP1;

public class Date
{
    protected int year;
    public int Year
    {
        get => year;
        set
        {
            if (value < 1)
            {
                throw new ArgumentException("Рік не може бути менше 1.");
            }
            year = value;
        }
    }

    protected int month;
    public int Month
    {
        get => month;
        set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException("Місяць повинен бути лише від 1 до 12");
            }
            month = value;
        }
    }

    protected int day;
    public int Day
    {
        get => day;
        set
        {
            if (value < 1 || value > 31)
            {
                throw new ArgumentException("День може бути від 1 до 31");
            }
            day = value;
        }
    }

    protected int hours;
    public int Hours
    {
        get => hours;
        set
        {
            if (value < 0 || value > 23)
            {
                throw new ArgumentException("Години можуть бути лише від 0 до 23");
            }
            hours = value;
        }
    }

    protected int minutes;
    public int Minutes
    {
        get => minutes;
        set
        {
            if (value < 0 || value > 59)
            {
                throw new ArgumentException("Хвилини повинні бути від 0 до 59");
            }
            minutes = value;
        }
    }

    public Date()
    {
        Year = 1;
        Month = 1;
        Day = 1;
        Minutes = 0;
        Hours = 0;
    }
    public Date(int year, int month, int day)
    {
        Year = year;
        Month = month;
        Day = day;
        Minutes = 0;
        Hours = 0;
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
        if (d1.Year == d2.Year && d1.Month == d2.Month && d1.Day == d2.Day && d1.Hours < d2.Hours)
            return true;
        if (d1.Year == d2.Year && d1.Month == d2.Month && d1.Day == d2.Day && d1.Hours == d2.Hours &&
            d1.Minutes < d2.minutes)
            return true;
        return false;
    }
    public static bool operator >(Date d1, Date d2)
    {
        if (d1.Year > d2.Year) 
            return true;
        if (d1.Year == d2.Year && d1.Month > d2.Month) 
            return true;
        if (d1.Year == d2.Year && d1.Month == d2.Month && d1.Day > d2.Day) 
            return true;
        if (d1.Year == d2.Year && d1.Month == d2.Month && d1.Day == d2.Day && d1.Hours > d2.Hours)
            return true;
        if (d1.Year == d2.Year && d1.Month == d2.Month && d1.Day == d2.Day && d1.Hours == d2.Hours &&
            d1.Minutes > d2.minutes)
            return true;
        return false;
    }
    public override string ToString()
    {
        return $"{Year}-{Month}-{Day}-{Hours}-{minutes}";
    }
}
