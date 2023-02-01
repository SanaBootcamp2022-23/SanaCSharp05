using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SanaCSharp05
{
     class Airplane
    {
        protected string startCity;
        protected string finishCity;
        protected Date startDate;
        protected Date finishDate;
        public string StartCity
        { set; get; }
        public string FinishCity
        { set; get; }
        public Date StartDate
        { set; get; }
        public Date FinishDate
        { set; get; }
        public Airplane()
        {
            StartCity = "Depart City";
            FinishCity = "Destination";
            StartDate = new Date(2023, "February", "Monday", 0, 0);
            FinishDate = new Date(2023, "February", "Monday", 0, 0);
        }
        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = new Date(startDate);
            FinishDate = new Date(finishDate);
        }
        public Airplane(string startCity, string finishCity)
        {
            StartCity = startCity;
            FinishCity = finishCity;
        }
        public Airplane(Date startDate, Date finishDate)
        {
            StartDate = new Date(startDate);
            FinishDate = new Date(finishDate);
        }
        public Airplane(Airplane obj) : this(obj.StartCity, obj.FinishCity, new Date(obj.StartDate), new Date(obj.FinishDate))
        { } 
        public bool IsArrivingToday()
        {
            if (StartDate.Day == FinishDate.Day && StartDate.Month == FinishDate.Month && StartDate.Year == FinishDate.Year)
                return true;
            else return false;
        }
        public uint GetTotalTime()
        {
            uint totalTime = 0;
            if (StartDate.Day == FinishDate.Day)
            {
                totalTime = ((FinishDate.Hour - StartDate.Hour - 1) * 60) + (60 - StartDate.Minutes + FinishDate.Minutes);
            }
            else totalTime = ((24 - StartDate.Hour + FinishDate.Hour-1) * 60) + (60 - StartDate.Minutes + FinishDate.Minutes);
            return totalTime;
        }
    }
    class Date
    {
        protected uint year;
        protected string month;
        protected string day;
        protected uint hour;
        protected uint minutes;
        public uint Year
        { set {
                if(Year>=0&& Year<=2023)
                    year = value;
            }
            get {
                return year;
            }
        }
        public string Month
        { set; get; }
        public string Day { set; get; }
        public uint Hour { 
            set {
                if(Hour>=0&& Hour<24)
                    hour = value;
            }
            get {
                return hour;
            } 
        }
        public uint Minutes {
            set { 
            if(Minutes>=0&&Minutes<60)
                    minutes = value;
            }
            get {
                return minutes;
            } 
        }
        public Date()
        {
            Year = 2023;
            Month = "Місяць";
            Day = "День";
            Hour = 0;
            Minutes = 0;
        }
        public Date(uint year, string month, string day, uint hour, uint minutes)
        {
            Year = year;
            Month = month;
            Day = day;
            Hour = hour;
            Minutes = minutes;
        }
        public Date(uint year, string month, string day)
        {
            Year = year;
            Month = month;
            Day = day;
        }
        public Date(string day, uint hour, uint minutes)
        {
            Day = day;
            Hour = hour;
            Minutes = minutes;
        }
        public Date(Date obj) : this(obj.Year, obj.Month, obj.Day, obj.Hour, obj.Minutes)
        { }
    }
    class Product
    {
        protected string name;
        protected double price;
        protected Currency cost;
        protected uint quantity;
        protected string producer;
        protected double weight;
        public string Name
        {
            set
            {
                if (value != "")
                    name = value;
            }
            get { return name; }
        }
        public double Price { set {
                if (value > 0)
                    price = value;
            }
            get
            {
                return price;
            }
        }
        public Currency Cost { set; get; }
        public uint Quantity { set {
                if (value >= 0)
                    quantity = value;
            }
            get {
                return quantity;
            }
        }
        public string Producer { set {
                if (value != "")
                    producer = value;
            } get { return producer; }
        }
        public double Weight { set {
                if (value > 0)
                    weight = value;
            }
            get { return weight; }
        }
        public Product()
        {
            Name = "Example name";
            Price = 1;
            Cost = new Currency();
            Quantity = 0;
            Producer = "Some company";
            Weight = 1;
        }
        public Product(string name, double price, Currency cost, uint quantity, string producer, double weight)
        {
            Name = name;
            Price = price;
            Cost = new Currency(cost);
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }
        public Product(string name, double price, string producer, uint quantity)
        {
            Name = name;
            Price = price;
            Producer = producer;
            Quantity = quantity;
        }
        public Product(Product copy)
        {
            Name = copy.Name;
            Price = copy.Price;
            Cost = new Currency(copy.Cost);
            Quantity = copy.Quantity;
            Producer = copy.Producer;
            Weight = copy.Weight;
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
            return Quantity * Weight;
        }
    }
    class Currency
    {
        protected string name;
        protected double exRate;
        public string Name { set {
                if (name != "")
                    name = value;
            } get { return name; }
        }
        public double ExRate { set { if (value > 0)
                    exRate = value;
            }
            get
            {
                return exRate;
            } }
        public Currency()
        {
            name = "Example name";
            exRate = 1;
        }
        public Currency(string name, double exRate)
        {
            Name = name;
            exRate = exRate;
        }
        public Currency(double exRate, string name)
        {
            Name = name;
            exRate = exRate;
        }
        public Currency(Currency copy)
        {
            name = copy.Name;
            exRate = copy.ExRate;
        }
    }
}
