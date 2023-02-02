using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Airplane--------------------");
            Airplane plane = new Airplane("Kyiv","Paris",new Date(2023,01,01,13,30), new Date(2023, 01, 01, 20, 30));
            plane.GetTotalTime();
            Console.WriteLine("Arriving today " + plane.IsArrivingToday());
            //---Prodcut
            Console.WriteLine("Product--------------------");
            Product product = new Product("Shoes", 700, new Currency("dollar", 8), 10, "Adidas", 0.400);
            Console.WriteLine($"Price in UAH: {product.GetPriceInUAH()}");
            Console.WriteLine($"Total price in UAH: {product.GetTotalPriceInUAH()}");
            Console.WriteLine($"Total weight: {product.GetTotalWeight()}kg");
        }
    }
}
