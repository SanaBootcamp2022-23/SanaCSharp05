using System;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Airplane airplane = new Airplane("Zhytomyr", "Kharkiv", new Date(2023, 2, 5, 8, 30), new Date(2023, 2, 5, 20, 30));
            airplane.Show();


            Console.WriteLine();
            Product product1 = new Product("Apple", "Farm", new Currency("UAH", 1), 4.5, 5, 0.3);
            Product product2 = new Product("Lemon", "Farm", new Currency("USD", 0.027), 0.27, 7, 0.2);
            product2.Show();
            Console.WriteLine();
            product1.Show();
        }
    }
}