using OOP1;

static void PrintAirplaneDetails(Airplane airplane, string name = "Plane")
{
    Console.WriteLine($"\n{name}:\n\tFrom: {airplane.StartCity}\n\tTo: {airplane.FinishCity}" +
    $"\n\tTakeoff: {airplane.StartDate}\n\tLanding: {airplane.FinishDate}" +
    $"\n\tTotal time: {airplane.GetTotalTime()} minutes" +
    $"\n\tIs arriving today: {(airplane.IsArrivingToday() ? "Yes" : "No")}");
}

Airplane airplane1 = new("Washington DC", "California", new(2023, 01, 30, 14, 45), new(2023, 01, 30, 19, 12));
Airplane airplane2 = airplane1.Copy();
airplane2.StartCity = "";
airplane2.FinishCity = "Sydney";
airplane2.StartDate = airplane2.FinishDate.Copy();
airplane2.StartDate.Minutes = 71;
airplane2.FinishDate = new(2023, 01, 31, 22, 57);

PrintAirplaneDetails(airplane1, "Plane 1");
PrintAirplaneDetails(airplane2, "Plane 2");
