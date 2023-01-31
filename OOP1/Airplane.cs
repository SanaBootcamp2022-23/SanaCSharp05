using System;

namespace OOP1;
public class Airplane {
    private string _startCity = "Undefined";
    private string _finishCity = "Undefined";
    private Date _startDate = new Date();
    private Date _finishDate = new Date();

    public string StartCity { get => _startCity; set => _startCity = value ?? "Undefined"; }
    public string FinishCity { get => _finishCity; set => _finishCity = value ?? "Undefined"; }
    public Date StartDate { get => _startDate; set => _startDate = value ?? new Date(); }
    public Date FinishDate { get => _finishDate; set => _finishDate = value ?? new Date(); }

    public Airplane() {}

    public Airplane(string startCity, string finishCity, Date startDate, Date finishDate) {
        this.StartCity = startCity;
        this.FinishCity = finishCity;
        this.StartDate = startDate;
        this.FinishDate = finishDate;
    }

    public Airplane(string startCity, string finishCity) {
        this.StartCity = startCity;
        this.FinishCity = finishCity;
    }

    public Airplane(Airplane airplane) {
        this.StartCity = airplane.StartCity;
        this.FinishCity = airplane.FinishCity;
        this.StartDate = new Date(airplane.StartDate);
        this.FinishDate = new Date(airplane.FinishDate);
    }

    public override string ToString(){
        return $"{this.StartCity} -> {this.FinishCity}, {this.StartDate} - {this.FinishDate}";
    }

    public int GetTotalTime() {
        return (int) new DateTime(this.FinishDate.Year, this.FinishDate.Month, this.FinishDate.Day, 
                                  this.FinishDate.Hours, this.FinishDate.Minutes, 0)
                        .Subtract(
                     new DateTime(this.StartDate.Year, this.StartDate.Month, this.StartDate.Day, 
                                  this.StartDate.Hours, this.StartDate.Minutes, 0)).TotalMinutes;
    }

    public bool IsArrivingToday() {
        return new DateTime(this.StartDate.Year, this.StartDate.Month, this.StartDate.Day)
            .Equals(new DateTime(this.FinishDate.Year, this.FinishDate.Month, this.FinishDate.Day));
    }
}

