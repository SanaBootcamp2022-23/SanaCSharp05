using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1;
public class Date
{
    protected int Year;
    protected int Month;
    protected int Day;
    protected int Hours;
    protected int Minutes;

    public Date() { }

    public Date(int year, int month, int day, int hours, int minutes)
    {
        this.Year = year;
        this.Month = month;
        this.Day = day;
        this.Hours = hours;
        this.Minutes = minutes;
    }
    public Date(int year, int month, int day)
    {
        this.Year = year;
        this.Month = month;
        this.Day = day;
    }

    public Date(int hours, int minutes)
    {
        this.Hours = hours;
        this.Minutes = minutes;
    }

    public Date(int year, int month, int day, int hours, int minutes, int v) : this(year, month, day, hours, minutes)
    {
    }

    public int YEar
    {
        get
        {
            return Year;
        }
        set
        {
            if (value >= 2023 && value <= 2030)
                Year = value;
        }
    }
    public int MOnth
    {
        get
        {
            return Month;
        }
        set
        {
            if (value >= 1 && value <= 12)
                Month = value;
        }
    }
    public int DAy
    {
        get
        {
            return Day;
        }
        set
        {
            if (value >= 1 && value <= 31)
                Day = value;
        }
    }
    public int HOurs
    {
        get
        {
            return Hours;
        }
        set
        {
            if (value >= 0 && value < 24)
                Hours = value;
        }
    }
    public int MInutes
    {
        get
        {
            return Minutes;
        }
        set
        {
            if (value >= 0 && value < 60)
                Minutes = value;
        }
    }
}