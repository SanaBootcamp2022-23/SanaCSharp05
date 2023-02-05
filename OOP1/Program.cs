using OOP1;
Date start = new Date(2023,12,22, 18, 40);
Date end = new Date(2023, 12, 23, 17, 20);
var airplane = new Airplane("maddft", "gfy", start, end );
var total = airplane.GetTotalTime();
Console.WriteLine(total);
Console.WriteLine(airplane.IsArrivingToday());


