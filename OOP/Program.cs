using System;
using OOP;
class Program
{
    static void Main(string[] args)
    {
        Date startdate = new Date(2000,3,4,5,45);
        Date finishdate = new Date(2000,3,5,3,00);
        Airplane airplane = new Airplane("Київ", "Житомир", new Date(2023,3,4,5,45), new Date(2023,3,5,3,00));
        Product prod = new Product("Laptop", 1000, new Currency("Euro", 39), 5,"Lenovo",4);
        Console.WriteLine(prod);
    }
}