// See https://aka.ms/new-console-template for more information
using OOP1;
using System.Text;
Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Airplane airplane = new Airplane("Zhytomyr","Lviv",new Date(2023,2,10,14,45),new Date(2023,2,10,16,30));
Console.WriteLine(  $"Airplane:" +
                    $"\n\ttFrom:        {airplane.StartCity}" +
                    $"\n\tTo:           {airplane.FinishCity}" +
                    $"\n\tStart time:   {airplane.StartDate}" +
                    $"\n\tFinish time:  {airplane.FinishDate}" +
                    $"\n\tTotal time:   {airplane.GetTotalTime()}"
                  );

Currency EUR = new Currency("Euro", 40.65);
var USD = new Currency("Dollar", 37.45);

Product Samsung = new Product("Samsung S10", 300, USD, 5, "Samsung", 300.5);
var iPhone = new Product("iPhone 11Pro", 400, USD, 5, "iPhone", 300.5);

Console.WriteLine(iPhone.GetPriceInUAH());
Console.WriteLine(iPhone.GetTotalPriceInUAH());
Console.WriteLine(Samsung.GetTotalWeight());