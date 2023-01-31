namespace OOP1;

public class Date
{
    private int year;
    private int month;
    private int day;
    private int hours;
    private int minutes;

    public int Year
    {
        get { return year; }
        set { SetYear(value); }
    }
    public int Month
    {
        get { return month; }
        set { SetMonth(value); }
    }
    public int Day
    {
        get { return day; }
        set { SetDay(value); }
    }
    public int Hours
    {
        get { return hours; }
        set { SetHours(value); }
    }
    public int Minutes
    {
        get { return minutes; }
        set { SetMinutes(value); }
    }

    private static DateTime Now => DateTime.Now;

    public Date() : this(Now) { }

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

    public Date(DateTime date) : this
    (
        date.Year,
        date.Month,
        date.Day,
        date.Hour,
        date.Minute
    )
    { }

    public Date(Date copiedDate) : this
    (
      copiedDate.Year,
      copiedDate.Month,
      copiedDate.Day,
      copiedDate.Hours,
      copiedDate.Minutes
    )
    { }

    public Date Copy() => new(this);

    public int TotalMinutes()
    {
        int total = 0;

        total += Hours * 60;
        total += Day * 24 * 60;
        total += Month * 31 * 24 * 60;
        total += Year * 12 * 31 * 24 * 60;

        return total + Minutes;
    }

    public override string ToString()
    {
        return $"{Day:00}.{Month:00}.{Year:00} {Hours:00}:{Minutes:00}";
    }

    private void SetYear(int value)
    {
        Errors.CheckForRangeError(value, "year", year => year is >= 0, "(>= 0)");
        year = value;
    }

    private void SetMonth(int value)
    {
        Errors.CheckForRangeError(value, "month", month => month is >= 1 and <= 12, "[1; 12]");
        month = value;
    }

    private void SetDay(int value)
    {
        Errors.CheckForRangeError(value, "day", day => day is >= 1 and <= 31, "[1, 31]");
        day = value;
    }

    private void SetHours(int value)
    {
        Errors.CheckForRangeError(value, "hours", hours => hours is >= 0 and <= 23, "[0, 23]");
        hours = value;
    }

    private void SetMinutes(int value)
    {
        Errors.CheckForRangeError(value, "minutes", minutes => minutes is >= 0 and <= 59, "[0, 59]");
        minutes = value;
    }
}

