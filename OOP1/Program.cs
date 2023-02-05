namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Airplane Class

            Date startDate = new Date(2022, 11, 20, 5);
            Date finishDate = new Date(2022, 11, 20, 21);
            
            Airplane airplane = new Airplane("Khorosten", "Zhytomyr", startDate, finishDate);

            //OutPut Airplane Methods
            Console.WriteLine("|Departure date| |Arrival date| |Flight time (min)|");
            Console.WriteLine($"|{$"{airplane.startDate.Day}.{airplane.startDate.Month}.{airplane.startDate.Year}",14}| |{$"{airplane.finishDate.Day}.{airplane.finishDate.Month}.{airplane.finishDate.Year}",12}| |{$"{airplane.GetTotalTime(startDate, finishDate)}",17}|"); 

            Console.WriteLine("\nDoes airplane arrives ar the same time as it taking off: " + airplane.IsArrivingToday(startDate, finishDate));

            //Product Class

            Currency cost = new Currency("Dolar", 40);

            Product product = new Product("Book", 12, cost, 25, "Walter White", 250);

            //OutPut Product Methods

           
            Console.WriteLine("\nProduct price: " + product.GetPriceInUAH() + " UAH");
            Console.WriteLine("Total price of products: " + product.GetTotalPriceInUAH() + " UAH");
            Console.WriteLine("Total weight: " + product.GetTotalWeight()/1000 + " Kg");

        }
    }
}