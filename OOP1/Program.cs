// See https://aka.ms/new-console-template for more information
using OOP1;
using System.Text;
Console.OutputEncoding = UTF8Encoding.UTF8;//українська мова у консолі

var StartPlane = new Airplane(new Date(2023,02,04,18,15), new Date(2023, 02, 04, 19, 17)); //перевірка конструктора з двома параметра ми
Console.WriteLine(StartPlane.GetTotalTime() + " хвилин");  // перевірка методу GetTotalTime
if (StartPlane.IsArrivingToday())                                                     // перевірка метода IsArrivingToday
    Console.WriteLine("Так,відправлення і прибуття проходить в той самий день");
else
    Console.WriteLine("Ні, відправлення і прибуття проходять у різні дні");

Currency USD = new ("United States Dollar",37.85);
var EUR = new Currency("Euro", 40.10);

var Iphone = new Product("Iphone", 500, USD,10,"Apple",350.50);
Product Ipad= new ("Ipad", 400, EUR,15,"Apple",350.50);

Console.WriteLine(Iphone.GetPriceInUAH());
Console.WriteLine(Iphone.GetTotalPriceInUAH());
Console.WriteLine(Iphone.GetTotalWeight());
Console.WriteLine(Ipad.GetPriceInUAH());
Console.WriteLine(Ipad.GetTotalPriceInUAH());
Console.WriteLine(Ipad.GetTotalWeight());




