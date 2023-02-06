// See https://aka.ms/new-console-template for more 
using OOP1;
using static OOP1.Display;

Airplane airplane1 = new Airplane();
airplane1.FinishDate.Hour = 13;
DisplayAirplane(airplane1);
Console.WriteLine("Airplane is arriving today - " + airplane1.IsArrivingToday());
Console.WriteLine("Total Time In Minutes - " + airplane1.GetTotalTime() + " min");

Console.WriteLine("***************");

Airplane airplane2 = new Airplane("Praha", "London");
airplane2.FinishDate.Day = 9;
airplane2.FinishDate.Minutes = 0;
DisplayAirplane(airplane2);
Console.WriteLine("Airplane is arriving today - " + airplane2.IsArrivingToday());
Console.WriteLine("Total Time In Minutes - " + airplane2.GetTotalTime() + " min");

Console.WriteLine("-----------------------");

Product product = new Product();
DisplayProduct(product);
Console.WriteLine("***************");
Console.WriteLine("Price in UAH : " + product.GetPriceInUAH() + " UAH");
Console.WriteLine("Total Price in UAH : " + product.GetTotalPriceInUAH() + " UAH");
Console.WriteLine("Total weight - " + product.GetTotalWeight() + " kg");
