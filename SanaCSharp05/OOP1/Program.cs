using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Date startDate = new Date(2022, 12, 31, 20, 15);
            Date finishDate = new Date(2023, 1, 1, 3, 5);
            Airplane airplane = new Airplane("Kyiv", "Istanbul", startDate, finishDate);

            Console.WriteLine($"Сумарний час подорожi у хвилинах: {airplane.GetTotalTime()}");

            if (airplane.IsArrivingToday())
                Console.WriteLine("Лiтак прибуває сьогоднi");
            else
                Console.WriteLine("Лiтак не прибуває сьогоднi");

            Currency cost = new Currency("Dollar", 37.43);
            Product graphicCard = new Product("RTX 3050", "NVidia", cost, 4, 0.3, 540);

            Console.WriteLine($"\nЦiна одиницi товару в гривнях: {graphicCard.GetPriceInUAH()}");
            Console.WriteLine($"Загальна вартiсть усiх наявних на складi товарiв даного виду: {graphicCard.GetTotalPriceInUAH()}");
            Console.WriteLine($"Загальна вага усiх товарiв на складi даного виду: {graphicCard.GetTotalWeight()}");
        }
    }
}
