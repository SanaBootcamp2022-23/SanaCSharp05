using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tAirplane test\n");
            Airplane airplane = new Airplane("Barcelona", "LA",
                new Date(2023, 10, 10, 20, 15), new Date(2023, 10, 11, 3, 10));
            Console.WriteLine($"Arriving today: {airplane.IsArrivingToday()}");
            Console.WriteLine($"Total time (in min): {airplane.GetTotalTime()}");
            Console.WriteLine("\n");

            Console.WriteLine("\t\tProduct test\n");
            Product product = new Product();
            Console.WriteLine($"Price in UAH: {product.GetPriceInUAH()}");
            Console.WriteLine($"Total price in UAH: {product.GetTotalPriceInUAH()}");
            Console.WriteLine($"Total weight: {product.GetTotalWeight()}");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
