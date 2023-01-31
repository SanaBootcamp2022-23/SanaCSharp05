using System;
using System.Net.Cache;

public class Airplane
{
	protected string StartCity;
	protected string FinishCity;
	protected Date StartDate;
	protected Date FinishDate;
	public Airplane()
	{
		StartCity = "Zhytomyr";
		FinishCity = "Odessa";
		StartDate = new Date();
		FinishDate = new Date();
	}
	public Airplane(string startCity, string finishCity, Date startDate, Date finishDate)
	{
		if (IsCityValid(startCity))
			StartCity = startCity;
		else
			throw new Exception("Start city is incorrect");
		if (IsCityValid(finishCity))
			FinishCity = finishCity;
		else
            throw new Exception("Start city is incorrect");

        StartDate = new Date(startDate);
		FinishDate = new Date(finishDate);
	}
	public Airplane (string startCity, string finishCity, Date startDate) : this(startCity, finishCity, startDate, new Date()) { 
	}
	
	public Airplane (Airplane obj): this(obj.StartCity, obj.FinishCity, obj.StartDate, obj.FinishDate)
	{

	}

	public string GetStartCity() =>StartCity;
	public string GetFinishCity()=> FinishCity;
	public Date GetStartDate() => StartDate;
	public Date GetFinishDate()=> FinishDate;

	public void SetStartCity(string startCity) => StartCity = startCity;
	public void SetFinishCity(string finishCity) => FinishCity = finishCity;
	public void SetStartDate(Date startDate) => StartDate = startDate;
	public void SetFinishDate(Date finishDate) => FinishDate = finishDate;
	public bool IsCityValid(string city)
	{
		if (city == null) return false;
		else return true;
	}

	public long GetTotalTime(Date startDate, Date finishDate) => (finishDate.GetYear() - startDate.GetYear()) * 365 * 24 * 60 + (finishDate.GetMonth() - startDate.GetMonth()) * 30 * 24 * 60 + (FinishDate.GetDay() - startDate.GetDay()) * 24 * 60 + (finishDate.GetMinutes() - startDate.GetMinutes()) + (finishDate.GetHours() - startDate.GetHours()) * 60; 
	
	public bool IsArrivingToday(Date startDate, Date finishDate)
	{
		if(startDate.GetYear()==finishDate.GetYear() && startDate.GetMonth==finishDate.GetMonth && startDate.GetDay==finishDate.GetDay)
			return true;
		else return false;
	}
}
