using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP1;
using static OOP1.Date;
using static OOP1.Airplane;
using static OOP1.Currency;
using static OOP1.Product;
using System.Text;

namespace OOP1
{
    public class Display
    {
        static public void DisplayDates(Date date)
        {
            Console.WriteLine($"{date.Day,2:d2}.{date.Month,2:d2}.{date.Year} {date.Hour,2:d2}:{date.Minutes,2:d2}");
        }
        static public void DisplayAirplane(Airplane airplane)
        {
            Console.WriteLine($"Start city: {airplane.StartCity}");
            Console.WriteLine($"Finish city: {airplane.FinishCity}");
            Console.Write("Start date: "); DisplayDates(airplane.StartDate);
            Console.Write("Finish date: "); DisplayDates(airplane.FinishDate);
        }
        static public void DisplayProduct(Product product)
        {
            Console.WriteLine("Name - " + product.Name);
            Console.Write("Price : " + product.Price + " ");
            DisplayCurrency(product.Cost); Console.WriteLine("UAH");
            Console.WriteLine("Quantity - " + product.Quantity + " pieces");
            Console.WriteLine("Producer - " + product.Producer + "");
            Console.WriteLine("Weight : " + product.Weight + " kg");
        }
        static public void DisplayCurrency(Currency currency)
        {
            Console.Write(currency.Name + " - " + currency.ExRate);
        }
    }
}
