using System;

namespace OOP1;
public class Date {
    public int Year { get; private set; } = 1;
    public int Month { get; private set; } = 1;
    public int Day { get; private set; } = 1;
    public int Hours { get; private set; }
    public int Minutes { get; private set; }

    public Date(int year, int month, int day, int hours, int minutes) {
        if (year < 0)
            throw new ArgumentOutOfRangeException("Year cannot be less than 0");
        if (month < 1 || month > 12)
            throw new ArgumentOutOfRangeException("Month must be in range 1-12");
        if (day < 1 || day > DateTime.DaysInMonth(year, month))
            throw new ArgumentOutOfRangeException("Invalid value of day");
        if (hours < 0 || hours > 23) 
            throw new ArgumentOutOfRangeException("Hours must be in range 0-23");
        if (minutes < 0 || minutes > 59)
            throw new ArgumentOutOfRangeException("Minutes must be in range 0-23");
        this.Year = year;
        this.Month = month;
        this.Day = day;
        this.Hours = hours;
        this.Minutes = minutes;
    }

    public Date(int hours, int minutes) {
        if (hours < 0 || hours > 23) 
            throw new ArgumentOutOfRangeException("Hours must be in range 0-23");
        if (minutes < 0 || minutes > 59)
            throw new ArgumentOutOfRangeException("Minutes must be in range 0-23");

        this.Year = DateTime.Now.Year;
        this.Month = DateTime.Now.Month;
        this.Day = DateTime.Now.Day;
        this.Hours = hours;
        this.Minutes = minutes;
    }

    public Date() {}

    public Date(Date date) {
        this.Month = date.Month;
        this.Year = date.Year;
        this.Hours = date.Hours;
        this.Day = date.Day;
        this.Minutes = date.Minutes;
    }

    public override string ToString() {
        return $"{this.Year}-{this.Month}-{this.Day} {this.Hours}:{this.Minutes}";
    }
}
