using OOP1;

Date sd = new Date(2023, 2, 2, 22, 50);
Date fd = new Date(2024, 4, 4, 23, 58);
Airplane airplane= new Airplane("1","2",sd,fd);
Console.WriteLine(airplane.GetTotalTime());
