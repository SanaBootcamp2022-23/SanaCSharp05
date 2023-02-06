namespace OOP1AirplaneClassLibrary;

public class Date
{
    protected int day;
    protected int hours;
    protected int minutes;

    protected int month;

    // ЗАХИЩЕНІ ПОЛЯ
    protected int year;

    //КОНСТРУКТОР по ЗАМОВЧУВАННЮ
    public Date()
    {
        year = 2023;
        month = 2;
        day = 1;
        hours = 12;
        minutes = 0;
    }

    //КОНСТРУКТОРИ з ПАРАМЕТРАМИ (5)
    public Date(int year, int month, int day, int hours, int minutes)
    {
        this.year = year;
        this.month = month;
        this.day = day;
        this.hours = hours;
        this.minutes = minutes;
    }

    public Date(int month, int day, int hours, int minutes)
    {
        year = 2023;
        this.month = month;
        this.day = day;
        this.hours = hours;
        this.minutes = minutes;
    }

    public Date(int day, int hours, int minutes)
    {
        year = 2023;
        month = 2;
        this.day = day;
        this.hours = hours;
        this.minutes = minutes;
    }

    public Date(int hours, int minutes)
    {
        year = 2023;
        month = 2;
        day = 1;
        this.hours = hours;
        this.minutes = minutes;
    }

    public Date(int minutes)
    {
        year = 2023;
        month = 2;
        day = 1;
        hours = 12;
        this.minutes = minutes;
    }

    //КОНСТРУКТОР КОПІЮВАННЯ
    public Date(Date date)
    {
        year = date.year;
        month = date.month;
        day = date.day;
        hours = date.hours;
        minutes = date.minutes;
    }

    // ВЛАСТИВОСТІ для кожного з переліченого полів
    public int Year
    {
        get => year;

        set
        {
            year = value switch
            {
                < 2023 => 2023,
                > 2100 => 2100,
                _ => value
            };
        }
    }

    public int Month
    {
        get => month;

        set
        {
            month = value switch
            {
                > 12 => 12,
                <= 0 => 1,
                _ => value
            };
        }
    }

    public int Day
    {
        get => day;

        set
        {
            day = value switch
            {
                > 31 when month is 1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                > 30 when month is 4 or 6 or 9 or 11 => 30,
                > 29 when year % 4 == 0 && month == 2 => 29,
                > 28 when month == 2 => 28,
                _ => value
            };
        }
    }

    public int Hours
    {
        get => hours;

        set
        {
            hours = value switch
            {
                > 23 => 23,
                < 0 => 0,
                _ => value
            };
        }
    }

    public int Minutes
    {
        get => minutes;

        set
        {
            minutes = value switch
            {
                > 59 => 59,
                < 0 => 0,
                _ => value
            };
        }
    }

    //Додатковий метод для ПОДАННЯ ДАТИ у ЗРУЧНОМУ ФОРМАТІ
    public string ToStringDate()
    {
        var date = $"{hours}:{minutes} {day}.{month}.{year}";
        if (month < 10) date = $"{hours}:{minutes}  {day}.0{month}.{year}.";
        if (day < 10) date = $"{hours}:{minutes}  0{day}.{month}.{year}.";
        if (hours < 10) date = $"0{hours}:{minutes}  {day}.{month}.{year}.";
        if (minutes < 10) date = $"{hours}:0{minutes} {day}.{month}.{year}.";
        if (minutes < 10 && hours < 10) date = $"0{hours}:0{minutes} {day}.{month}.{year}.";
        if (minutes < 10 && day < 10) date = $"{hours}:0{minutes} 0{day}.{month}.{year}.";
        if (minutes < 10 && month < 10) date = $"{hours}:0{minutes} {day}.0{month}.{year}.";
        if (hours < 10 && day < 10) date = $"0{hours}:{minutes} 0{day}.{month}.{year}.";
        if (hours < 10 && month < 10) date = $"0{hours}:{minutes} {day}.0{month}.{year}.";
        if (day < 10 && month < 10) date = $"{hours}:{minutes} 0{day}.0{month}.{year}.";
        if (minutes < 10 && day < 10 && month < 10) date = $"{hours}:0{minutes} 0{day}.0{month}.{year}.";
        if (minutes < 10 && hours < 10 && day < 10) date = $"0{hours}:0{minutes} 0{day}.{month}.{year}.";
        if (minutes < 10 && hours < 10 && month < 10) date = $"0{hours}:0{minutes} {day}.0{month}.{year}.";
        if (hours < 10 && day < 10 && month < 10) date = $"0{hours}:{minutes} 0{day}.0{month}.{year}.";
        if (minutes < 10 && hours < 10 && day < 10 && month < 10) date = $"0{hours}:0{minutes} 0{day}.0{month}.{year}.";

        return date;
    }
}