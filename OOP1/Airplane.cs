namespace OOP1;

public class Airplane
{
    public string StartCity { get; set; } = string.Empty;
    public string FinishCity { get; set; } = string.Empty;
    public Date StartDate { get; set; } = new();
    public Date FinishDate { get; set; } = new();

    public Airplane() { }

    public Airplane(
      string startCity,
      string finishCity,
      Date startDate,
      Date finishDate)
    {
        StartCity = startCity;
        FinishCity = finishCity;
        StartDate = startDate;
        FinishDate = finishDate;
    }

    public Airplane(Date startDate, Date finishDate)
    {
        StartDate = startDate;
        FinishDate = finishDate;
    }

    public Airplane(Airplane copiedAirplane) : this
    (
        copiedAirplane.StartCity,
        copiedAirplane.FinishCity,
        copiedAirplane.StartDate.Copy(),
        copiedAirplane.FinishDate.Copy()
    )
    { }

    public Airplane Copy() => new(this);

    public bool IsArrivingToday() =>
      FinishDate.Day == StartDate.Day
        && FinishDate.Month == StartDate.Month
        && FinishDate.Year == StartDate.Year;

    public int GetTotalTime()
    {
        return FinishDate.TotalMinutes() - StartDate.TotalMinutes();
    }

    public override string ToString()
    {
        return $"\"{StartCity} -> {FinishCity}\", {GetTotalTime()} minutes, ({StartDate}) - ({FinishDate})";
    }
}
