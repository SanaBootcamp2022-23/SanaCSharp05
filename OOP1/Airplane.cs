namespace OOP1;

public class Airplane
{
    private string startCity;
    private string finishCity;
    private Date startDate;
    private Date finishDate;

    public Airplane()
    {
        StartCity = "";
        FinishCity = "";
        StartDate = new Date();
        FinishDate = new Date();
    }
    public Airplane(string startCity, string finishCity)
    {
        StartCity = startCity;
        FinishCity = finishCity;
        StartDate = new Date();
        FinishDate = new Date();
    }
    public Airplane(string startCity, string finishCity, Date startDate, Date finishDate)
    {
        StartCity = startCity;
        FinishCity = finishCity;
        StartDate = startDate;
        FinishDate = finishDate;
    }
    public Airplane(Airplane original)
    {
        StartCity = original.startCity;
        FinishCity = original.finishCity;
        StartDate = original.startDate;
        FinishDate = original.finishDate;
    }

    public string StartCity
    {
        get => startCity;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Start city cannot be empty.");
            startCity = value;
        }
    }

    public string FinishCity
    {
        get => finishCity;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Finish city cannot be empty.");
            finishCity = value;
        }
    }

    public Date StartDate
    {
        get => startDate;
        set
        {
            if (value == null)
                throw new ArgumentException("Start date cannot be null.");
            startDate = value;
        }
    }

    public Date FinishDate
    {
        get => finishDate;
        set
        {
            if (value == null)
                throw new ArgumentException("Finish date cannot be null.");
            if (value < startDate)
                throw new ArgumentException("Finish date cannot be earlier than start date.");
            finishDate = value;
        }
    }
    public int GetTotalTime()
    {
        int totalMinutes = 0;

        totalMinutes += (FinishDate.Day - StartDate.Day) * 1440;
        totalMinutes += (FinishDate.Hours - StartDate.Hours) * 60;
        totalMinutes += (FinishDate.Minutes - StartDate.Minutes);

        return totalMinutes;
    }
    public bool IsArrivingToday()
    {
        return StartDate.Day == FinishDate.Day &&
               StartDate.Month == FinishDate.Month &&
               StartDate.Year == FinishDate.Year;
    }
}
