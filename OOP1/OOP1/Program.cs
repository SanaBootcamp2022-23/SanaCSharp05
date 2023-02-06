namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class Airplane
    {
        protected string startCity;
        protected string finishCity;
        protected Date startDate;
        protected Date finishDate;

        public string StartCity { get; private set; }
        public string FinishCity { get; private set; }
        public Date StartDate { get; private set; }
        public Date FinishDate { get; private set; }

        public Airplane()
        {
            StartCity = "CityA";
            FinishCity = "CityB";
            StartDate = new Date();
            FinishDate = new Date();
        }

        public Airplane(string StartCity, string FinishCity)
        {
            startCity = StartCity;
            finishCity = FinishCity;
        }

        public Airplane(Date StartDate, Date FinishDate)
        {
            startDate = StartDate;
            finishDate = FinishDate;
        }

        public Airplane(Airplane airplane)
        {
            startCity = airplane.startCity;
            finishCity = airplane.finishCity;
            startDate = airplane.startDate;
            finishDate = airplane.finishDate;
        }

        public float GetTotalTime()
        {
            Date start = StartDate;
            Date finish = FinishDate;
            float travelMinutes = (float)(new DateTime(start.Year, start.Month, start.Day, start.Hours, start.Minutes, 0) -
                new DateTime(finish.Year, finish.Month, finish.Day, finish.Hours, finish.Minutes, 0)).TotalMinutes;

            return travelMinutes;
        }

        public bool IsArrivingToday()
        {
            if (StartDate.Year == FinishDate.Year && StartDate.Month == FinishDate.Month && StartDate.Day == FinishDate.Day)
            {
                return true;
            }
            return false;
        }
    }

    public class Date
    {
        protected int year;
        protected int month;
        protected int day;
        protected int hours;
        protected int minutes;

        public int Year { get; private set; }
        public int Month { get; private set; }
        public int Day { get; private set; }
        public int Hours { get; private set; }
        public int Minutes { get; private set; }

        public Date()
        {
            Year = DateTime.Now.Year;
            Month = DateTime.Now.Month;
            Day = DateTime.Now.Day;
            Hours = DateTime.Now.Hour;
            Minutes = DateTime.Now.Minute;
        }

        public Date(int year, int month, int day)
        {
            Year = Year;
            Month = Month;
            Day = Day;
        }

        public Date(int year, int month, int day, int hours, int minutes)
        {
            Year = year;
            Month = month;
            Day = day;
            Hours = hours;
            Minutes = minutes;
        }

        public Date(Date date)
        {
            Year = date.year;
            Month = date.month;
            Day = date.day;
            Hours = date.hours;
            Minutes = date.minutes;
        }
    }

    public class Product
    {
        protected string name;
        protected double price;
        protected Currency cost;
        protected int quantity;
        protected string producer;
        protected double weight;

        public string Name { get; private set; }
        public double Price { get; private set; }
        public Currency Cost { get; private set; }
        public int Quantity { get; private set; }
        public string Producer { get; private set; }
        public double Weight { get; private set; }

        public Product()
        {
            Name = "Default Product Name";
            Price = 1;
            Cost = new Currency();
            Quantity = 1;
            Producer = "Default Producer";
            Weight = 1;
        }

        public Product(string name, double price, Currency cost, int quantity, string producer, double weight)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public Product(Product product)
        {
            Name = product.Name;
            Price = product.Price;
            Cost = product.Cost;
            Quantity = product.Quantity;
            Producer = product.Producer;
            Weight = product.Weight;
        }

        public double GetPriceInUAH()
        {
            return Price * Cost.ExRate;
        }
        public double GetTotalPriceInUAH()
        {
            return Price * Cost.ExRate * Quantity;
        }

        public double GetTotalWeight()
        {
            return Weight * Quantity;
        }
    }

    public class Currency
    {
        protected string name;
        protected double exRate;

        public string Name { get; private set; }
        public double ExRate { get; private set; }

        public Currency()
        {
            Name = "US";
            ExRate = 0.025;
        }

        public Currency(string name, double exRate)
        {
            Name = name;
            ExRate = exRate;
        }

        public Currency(string name)
        {
            Name = name;
        }

        public Currency(Currency currency)
        {
            Name = currency.Name;
            ExRate = currency.ExRate;
        }
    }
}