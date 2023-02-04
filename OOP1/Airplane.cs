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

    public Airplane(string startCity, string finishCity, Date startDate, Date finishDate)
    {
        StartCity = startCity;
        FinishCity = finishCity;
        StartDate = startDate;
        FinishDate = finishDate;
    }

    public string StartCity
    {
        get { return startCity; }
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Start city cannot be empty.");
            startCity = value;
        }
    }

    public string FinishCity
    {
        get { return finishCity; }
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Finish city cannot be empty.");
            finishCity = value;
        }
    }

    public Date StartDate
    {
        get { return startDate; }
        set
        {
            if (value == null)
                throw new ArgumentException("Start date cannot be null.");
            startDate = value;
        }
    }

    public Date FinishDate
    {
        get { return finishDate; }
        set
        {
            if (value == null)
                throw new ArgumentException("Finish date cannot be null.");
            if (value < startDate)
                throw new ArgumentException("Finish date cannot be earlier than start date.");
            finishDate = value;
        }
    }
}
