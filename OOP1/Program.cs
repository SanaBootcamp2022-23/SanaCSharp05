namespace OOP1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Flight flights = new()
            {
                new("Мiсто 1", "Мiсто 5", new Date(DateTime.Now), new Date(DateTime.Now.AddMinutes(420))),
                new("Мiсто 2", "Мiсто 6", new Date(DateTime.Now), new Date(DateTime.Now.AddMinutes(60))),
                new("Мiсто 3", "Мiсто 7", new Date(DateTime.Now), new Date(DateTime.Now.AddMinutes(150))),
                new("Мiсто 4", "Мiсто 8", new Date(DateTime.Now), new Date(DateTime.Now.AddDays(1)))
            };

            Console.WriteLine($"{"Мiсто вiдправлення",-5} {"Мiсто прибуття",-5} {"Дата вiдправлення",-25} {"Дата прибуття"}");
            for (int i = 0; i < flights.Count; i++)
                Console.WriteLine(flights[i].ToString());
        }
    }
}