using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args) // example of class usage
        {
            AirPlane firstTour = new AirPlane(Cities.Kyiv, Cities.Warsaw, new Date(2023, 2, 12, 16, 0), new Date(2023, 2, 12, 20, 30));

            bool flag = firstTour.IsArrrivingToday();
            Console.WriteLine("IsArrivingToday?" + flag);
            Console.WriteLine("Time to travel (in minutes): " + firstTour.GetTotalTime());

            //copy and change day
            AirPlane secondTour = new AirPlane(firstTour);
            secondTour.FinishDate.Day = 13;

            flag = secondTour.IsArrrivingToday();
            Console.WriteLine("IsArrivingToday?" + flag);
            Console.WriteLine("Time to travel (in minutes): " + secondTour.GetTotalTime());


            Currency usd = new Currency("USD", 35);
            Product window = new Product("Window", 50, usd, 24, "VEKA", 9);

            Console.WriteLine("Window cost in UAH: " + window.GetPriceInUAH());
            Console.WriteLine("Total window cost in UAH: " + window.GetTotalPriceInUAH());
            Console.WriteLine("Total weight of all windows: " + window.GetTotalWeight());
        }

    }
}
