using OOP1;
using System.Numerics;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

// Airplane+Date task

{
    Date date1Start = new Date(2023, 02, 09, 12, 15);
    Date date1End = new Date(2023, 02, 09, 18, 15);
    Airplane plane1 = new Airplane("Zhytomir", "Budapest", date1Start, date1End);

    Airplane plane2 = new Airplane("Rimini", "Kiev", new Date(2023, 03, 09, 12, 15), new Date(2023, 03, 10, 13, 15));

    Console.WriteLine($"GetTotalTime(), який обраховує сумарний час подорожі у хвилинах.                            {plane2.GetTotalTime()}\n");
    Console.WriteLine($"IsArrivingToday(), що повертає true, якщо відправлення і прибуття в той же день.            {plane2.IsArrivingToday()}\n");
}

// Product+Currency task
{
    Currency USD = new Currency();
    Product phone = new Product("SamsungA51", 200, 1, "Samsung", 200, USD);

    Product phone2 = new Product("SamsungS51", 700, 5, "Samsung", 220, new Currency("EUR", 39.49));


    Console.WriteLine($"GetPriceInUAH(), який повертає ціну одиниці товару в гривнях.                                       {phone2.GetPriceInUAH()}\n");
    Console.WriteLine($"GetTotalPriceInUAH(), що повертає загальну вартість усіх наявних на складі товарів даного виду.     {phone2.GetTotalPriceInUAH()}\n");
    Console.WriteLine($"GetTotalWeight(), який повертає загальну вагу усіх товарів на складі даного виду.                   {phone2.GetTotalWeight()}\n");
}


