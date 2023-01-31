using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Date
{
	protected int Year;
	protected int Month;
	protected int Day;
	protected int Hours;
	protected int Minutes;

	public Date()
	{
		Year = 2022;
		Month = 12;
		Day = 2;
		Hours = 22;
		Minutes = 22;
	}

	public Date(int year, int month, int day, int hours, int minutes)
	{
		Year = year;
		Month = month;
		Day = day;
		Hours = hours;
		Minutes = minutes;
	}
	public Date(int year, int month, int day, int hours):this (year, month, day, hours, 22)	
	{
      
    }

    public int GetYear() => Year;
    public int GetMonth() => Month;
    public int GetDay() => Day;
    public int GetHours() => Hours;
    public int GetMinutes() => Minutes;

	public void SetYear(int year)
	{
		Year=year;
	}
	public void SetMonth(int month)
	{
		Month=month;
	}
	public void SetDay(int day)
	{
		Day=day;	
	}
	public void SetHours(int hours)
	{
		Hours=hours;	
	}
	public void SetMinutes(int minutes)
	{
		Minutes=minutes;
	}
    public Date (Date obj) : this(obj.Year, obj.Month, obj.Day, obj.Hours, obj.Minutes)
	{
	
	}
}
