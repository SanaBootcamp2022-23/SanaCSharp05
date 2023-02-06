namespace OOP1AirplaneClassLibrary;

public class Airplane
{
    protected string finishCity; //місто прибуття

    protected Date finishDate; //дата прибуття

    //ЗАХИЩЕНІ ПОЛЯ
    protected string startCity; //місто відправлення
    protected Date startDate; //дата відправлення

    //КОНСТРУКТОР по ЗАМОВЧУВАННЮ 
    public Airplane()
    {
        startCity = "Paris";
        finishCity = "New York";
        startDate = new Date();
        finishDate = new Date(21, 40);
    }

    //КОНСТРУКТОРИ з ПАРАМЕТРАМИ (8)
    public Airplane(string startCity, string finishCity, Date startDate, Date finishDate, double rangeInKilometers)
    {
        this.startCity = startCity;
        this.finishCity = finishCity;
        this.startDate = startDate;
        this.finishDate = finishDate;
    }

    public Airplane(string startCity, string finishCity, Date startDate, Date finishDate)
    {
        this.startCity = startCity;
        this.finishCity = finishCity;
        this.startDate = startDate;
        this.finishDate = finishDate;
    }

    public Airplane(string finishCity, Date startDate, Date finishDate)
    {
        startCity = "Paris";
        this.finishCity = finishCity;
        this.startDate = startDate;
        this.finishDate = finishDate;
    }

    public Airplane(Date startDate, Date finishDate)
    {
        startCity = "Paris";
        finishCity = "New York";
        this.startDate = startDate;
        this.finishDate = finishDate;
    }

    public Airplane(Date finishDate)
    {
        startCity = "Paris";
        finishCity = "New York";
        startDate = new Date();
        this.finishDate = finishDate;
    }

    //КОНСТРУКТОР КОПІЮВАННЯ
    public Airplane(Airplane airplane)
    {
        startCity = airplane.startCity;
        finishCity = airplane.finishCity;
        startDate = new Date(airplane.startDate);
        finishDate = new Date(airplane.finishDate);
    }

    //ВЛАСТИВОСТІ ДЛЯ ПОЛІВ
    public string StartCity
    {
        get => startCity;
        set => startCity = value;
    }

    public string FinishCity
    {
        get => finishCity;
        set => finishCity = value;
    }

    public Date StartDate
    {
        get => startDate;
        set => startDate = value;
    }

    public Date FinishDate
    {
        get => finishDate;
        set => finishDate = value;
    }

    //Обрахунок сумарного ЧАСУ ПОДОРОЖІ у ХВИЛИНАХ 
    public int GetTotalTime()
    {
        var start = new DateTime(startDate.Year, startDate.Month, startDate.Day, startDate.Hours, startDate.Minutes, 0);
        var finish = new DateTime(finishDate.Year, finishDate.Month, finishDate.Day, finishDate.Hours,
            finishDate.Minutes, 0);

        var minutes = (int)(finish - start).TotalMinutes;
        return minutes;
    }

    //Повертає TRUE, якщо ВІДПРАВЛЕННЯ і ПРИБУТТЯ в ТОЙ ЖЕ ДЕНЬ
    public bool IsArrivingToday()
    {
        var isArrivingToday = startDate.Day == finishDate.Day;
        return isArrivingToday;
    }

    public string ToString()
    {
        return
            $"Start city: {StartCity}\n" +
            $"Finish city: {FinishCity}\n" +
            $"Start date: {startDate.ToStringDate()}\n" +
            $"Finish date: {finishDate.ToStringDate()}\n" +
            $"Arriving today: {IsArrivingToday()}\n" +
            $"Total time: {GetTotalTime()}";
    }
}