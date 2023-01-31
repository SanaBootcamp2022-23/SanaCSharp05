using System;

namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
        }
    }
    class Airplane
    {
        protected string StartCity = null!;
        protected string FinishCity = null!;
        protected Date StartDate = null!;
        protected Date FinishDate = null!;
        public Airplane()
        {
            StartCity = "Київ";
            FinishCity = "Лондон";
            StartDate = new Date();
            FinishDate = new Date();
        }
        public Airplane(string StartCity, string FinishCity, Date StartDate, Date FinishDate)
        {
            this.StartCity = StartCity;
            this.FinishCity = FinishCity;
            this.StartDate = new(StartDate);
            this.FinishDate = new(FinishDate);
        }
        public Airplane(string StartCity, string FinishCity)
        {
            this.StartCity = StartCity;
            this.FinishCity = FinishCity;
            this.StartDate = new();
            this.FinishDate = new();
        }
        public Airplane(string StartCity, string FinishCity, Date StartDate)
        {
            this.StartCity = StartCity;
            this.FinishCity = FinishCity;
            this.StartDate = new(StartDate);
            this.FinishDate = new();
        }
        public Airplane(Airplane oldAirplane)
        {
            this.StartCity = oldAirplane.StartCity;
            this.FinishCity = oldAirplane.FinishCity;
            this.StartDate = new Date(oldAirplane.StartDate);
            this.FinishDate = new Date(oldAirplane.FinishDate);

        }
        public string GetStartCity() => this.StartCity;
        public string GetFinishCity() => this.FinishCity;
        public Date GetStartDate() => this.StartDate;
        public Date GetFinishDate() => this.FinishDate;

        public void SetStartCity(string StartCity)
        {
            this.StartCity = StartCity;
        }
        public void SetFinishCity(string FinishCity)
        {
            this.FinishCity = FinishCity;
        }
        public void SetStartDate(Date StartDate)
        {
            this.StartDate = new(StartDate);
        }
        public void SetFinishDate(Date FinishDate)
        {
            this.FinishDate = new(FinishDate);
        }
        public long GetTotalTime() => -((StartDate.GetYear() - FinishDate.GetYear()) * 365 * 24 * 60 + (StartDate.GetMonth() - FinishDate.GetMonth()) * 30 * 24 * 60 + (StartDate.GetDay() - FinishDate.GetDay()) * 24 * 60 + (StartDate.GetHours() - FinishDate.GetHours()) * 60 + (StartDate.GetMinutes() - FinishDate.GetMinutes()));
        public bool IsArrivingToday() => StartDate.GetDay() == FinishDate.GetDay();
        public override string ToString() => $"Start date  : {StartDate.ToString()}\n" +
                                             $"Start city  : {StartCity}\n" +
                                             $"Finish date : {FinishDate.ToString()}\n" +
                                             $"Finish city : {FinishCity}\n" +
                                             $"Total time in minutes : {GetTotalTime()}\n" +
                                             $"Is arriving today : {IsArrivingToday()}";
    }
    class Date
    {
        protected int Year;
        protected int Month;
        protected int Day;
        protected int Hours;
        protected int Minutes;

        public Date()
        {
            Year = 2001;
            Month = 01;
            Day = 01;
            Hours = 00;
            Minutes = 00;

        }
        public Date(int year, int mouth, int day, int hours, int minutes)
        {
            Year = year;
            Month = mouth;
            Day = day;
            Hours = hours;
            Minutes = minutes;
        }
        public Date(int year, int mouth, int day, int hours)
        {
            Year = year;
            Month = mouth;
            Day = day;
            Hours = hours;
            Minutes = 01;
        }
        public Date(int year, int mouth, int day)
        {
            Year = year;
            Month = mouth;
            Day = day;
            Hours = 00;
            Minutes = 00;
        }
        public Date(Date oldObject)
        {
            Year = oldObject.Year;
            Month = oldObject.Month;
            Day = oldObject.Day;
            Hours = oldObject.Hours;
            Minutes = oldObject.Minutes;

        }
        public int GetYear() => this.Year;
        public int GetMonth() => this.Month;
        public int GetDay() => this.Day;
        public int GetHours() => this.Hours;
        public int GetMinutes() => this.Minutes;

        public void SetYear(int Year)
        {
            this.Year = Year;
        }
        public void SetMonth(int Month)
        {
            this.Month = Month;
        }
        public void SetDay(int Day)
        {
            this.Day = Day;
        }
        public void SetHours(int Hours)
        {
            this.Hours = Hours;
        }
        public void SetMinutes(int Minutes)
        {
            this.Minutes = Minutes;
        }
        public override string ToString() => $"{Day}.{Month}.{Year}  {Hours}:{Minutes}";
    }
    class Product
    {
        protected string name = null!;
        protected double price;
        protected Currency cost;
        protected int quantity;
        protected string producer = null!;
        protected double weight;

        public string Name { get { return name; } set { name = value; } }
        public double Price { get { return price; } set { price = value; } }
        public Currency Cost { get { return cost; } set { cost = new(value); } }
        public int Quantity { get { return quantity; } set { quantity = value; } }
        public string Producer { get { return producer; } set { producer = value; } }
        public double Weight { get { return weight; } set { weight = value; } }
        public Product()
        {
            this.name = "Banana";
            this.price = 00.00;
            this.cost = new();
            this.quantity = 00;
            this.producer = "IOCompany";
            this.weight = 00;
        }

        public Product(string name, double price, Currency cost, int quantity, string producer, double weight)
        {
            this.name = name;
            this.price = price;
            this.cost = new(cost);
            this.quantity = quantity;
            this.producer = producer;
            this.weight = weight;
        }
        public Product(string name, double price, Currency cost, int quantity, double weight)
        {
            this.name = name;
            this.price = price;
            this.cost = new(cost);
            this.quantity = quantity;
            this.producer = "IOCompany";
            this.weight = weight;
        }
        public Product(Product oldobj) 
        {
            this.quantity= oldobj.quantity;
            this.producer = oldobj.producer;
            this.weight = oldobj.weight;
            this.price= oldobj.price;
            this.cost= new(oldobj.cost);
            this.name = oldobj.name;
        }
        public double GetPriceInUAH() => price * cost.ExRate;
        public double GetTotalPriceInUAH() => price * cost.ExRate * quantity;
        public double GetTotalWeight() => weight * quantity;
        public override string ToString()
        {
            return $"Name : {name}\n" +
                   $"Price : {price}\n" +
                   $"{cost.ToString()}\n" +
                   $"Quantity : {quantity}\n" +
                   $"Producer : {producer}\n" +
                   $"Weight : {weight}\n" +
                   $"PriceInUAH : {GetPriceInUAH()}\n" +
                   $"TotalPriceInUAH : {GetTotalPriceInUAH()}\n" +
                   $"TotalWeight : {GetTotalWeight()}";
        }
    }
    class Currency
    {
        protected string name = null!;
        protected double exRate;


        public string Name { get { return name; } set { name = value; } }
        public double ExRate { get { return exRate; } set { exRate = value; } }
        public Currency()
        {
            name = "Undefined";
            exRate = 0.0;
        }

        public Currency(string name, double exRate)
        {
            this.name = name;
            this.exRate = exRate;
        }
        public Currency(double exRate)
        {
            this.name = "Undefined";
            this.exRate = exRate;
        }
        public Currency(Currency oldObject)
        {
            this.name = oldObject.name;
            this.exRate = oldObject.exRate;
        }
        public override string ToString()
        {
            return $"Name of currency : {name}\n" +
                   $"Rate to UAH : {exRate}";
        }
    }
}