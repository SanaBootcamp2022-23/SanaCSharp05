using Microsoft.VisualBasic;
using OOP1;
Console.WriteLine("_______Airplane1_______ ");
Date first = new Date(2022,10,17,12,40);
Date finish = new Date(2022, 10, 17, 20, 40);
//finish.PrintDate();
//first.PrintDate();
Airplane airplane=new Airplane("Kyiv","Lviv",first,finish);
airplane.PrintAir();
Console.WriteLine("Total Time: " + airplane.GetTotalTime());
Console.WriteLine("Total Time: " + airplane.IsArrivingToday());
Console.WriteLine("_______Airplane2_______ ");
Date first1 = new Date(2022, 10, 17, 12, 40);
Date finish1 = new Date(2022, 10, 18, 20, 40);
Airplane airplane2 = new Airplane("Kyiv", "Lviv", first1, finish1);
airplane2.PrintAir();
Console.WriteLine("Total Time: " + airplane2.GetTotalTime());
Console.WriteLine("One day: " + airplane2.IsArrivingToday());
Console.WriteLine("_______Product_______ ");
Currency currencyUAH = new Currency("UAH",2);
Product product = new Product("Laptop",55000,currencyUAH,2,"Lenovo",2000);
product.PrintProd();
Console.WriteLine("GetPriceInUAH: " + product.GetPriceInUAH());
Console.WriteLine("GetTotalPriceInUAH: " + product.GetTotalPriceInUAH());
Console.WriteLine("GetTotalWeight: " + product.GetTotalWeight());


