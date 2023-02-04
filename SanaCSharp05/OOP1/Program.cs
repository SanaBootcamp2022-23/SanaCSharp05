using OOP1.Classes;
using OOP1.Classes.Journey;
using OOP1.Classes.StorageRoom;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;


Date startDate = new Date(2023, 2, 10, 13, 30);
Date finishDate = new Date(2023, 2, 10, 14, 30);

Airplane ticket1 = new Airplane("Київ", "Львів", startDate, finishDate);
Airplane ticket2 = new Airplane(ticket1);

Airplane ticket3 = new Airplane();
Airplane ticket4 = new Airplane("Бердичів");
Airplane ticket5 = new Airplane("Дніпро", "Луцьк");

PrintWithDifferentColor.PrintGreenColor("Квиток, створений конструктором по замовчуванню: ");
Console.WriteLine(ticket3.ToString());


ticket2.FinishCity = "Харків";
ticket2.FinishDate.Hours = 15;
ticket2.FinishDate.Month = 3;


PrintWithDifferentColor.PrintGreenColor("Перший квиток: ");
Console.WriteLine(ticket1.ToString());

PrintWithDifferentColor.PrintGreenColor("Другий квиток: ");
Console.WriteLine(ticket2.ToString());


Console.WriteLine($"Час подорожі першого квитка: {ticket1.GetTotalTime()} \n" +
    $"Час подорожі другого квитка: {ticket2.GetTotalTime()}");

string str = "Відправлення і прибуття для першого квитка: ";
str += ticket1.IsArrivingToday() ? "в той же день" : "в інший день";
Console.WriteLine(str);

PrintWithDifferentColor.PrintMagentaColor("\n*****************************************************************************\n");

Product product1 = new Product();
Product product2 = new Product(product1);

product2.Name = "Phone";
product2.Price = 17000;
product2.Cost.Name = "USD";
product2.Cost.ExRate = 37.28M;

PrintWithDifferentColor.PrintMagentaColor("Перший товар: ");
Console.WriteLine(product1.ToString());
Console.WriteLine($"\nЗагальна вага усіх наявних на складі товарів {product1.Name} {product1.Producer}: {product1.GetTotalWeight()}\n");

PrintWithDifferentColor.PrintMagentaColor("Другий товар: ");
Console.WriteLine(product2.ToString());
Console.WriteLine($"\nЗагальна вартість усіх наявних на складі товарів {product2.Name} {product2.Producer}: {product2.GetTotalPriceInUAH()}\n");

Product product3 = new Product("Phone", "Samsung", 230M, 2, new Currency(), 0.2M);

PrintWithDifferentColor.PrintMagentaColor("Третій товар: ");
Console.WriteLine(product3.ToString());
Console.WriteLine($"\nЦіна третього товару в гривнях: {product3.GetPriceInUAH()}");

