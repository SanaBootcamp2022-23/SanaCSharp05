
using OOP1;

namespace OOP1
{
    class Program {

        static void Main(string[] args)
        {
            #region Realization of class "Airplane"
            //Initialization of plane
            Airplane airplane = new Airplane()
            {
                StartCity = "Ukraine",
                FinishCity = "Polska",
                StartDate = new Date(00, 08),
                FinishDate = new Date(30, 20, 3)
            };


            //Output information of plane initialized above
            Console.WriteLine($"Expample of using class \"Airplane\":" +
                $"\n\tFrom: {airplane.StartCity}" +
                $"\n\tTo:   {airplane.FinishCity}" +
                $"\n\tDate of start:  " + OutputDate(airplane.StartDate) +
                $"\n\tDate of finish: " + OutputDate(airplane.FinishDate));
            #endregion

            #region Realization of class "Product"
            Product product = new Product()
            {
                Name = "Test",
                Price = 10,
                Cost = new Currency()
                {
                    Name = CurrencyName.USD,
                    ExRate = 36.93,
                },
                Quantity = 10,
                Producer = "Some creator",
                Weight = 10,
            };

            Console.WriteLine($"\nExample for using class \"Product\":" +
                $"\n\tName     = {product.Name}" +
                $"\n\tPrice    = {product.Price} {product.Cost.Name} ({product.GetPriceInUAH()} UAH)" +
                $"\n\tQuantity = {product.Quantity}" +
                $"\n\tProducer = {product.Producer}" +
                $"\n\tWeight   = {product.Weight}");

            #endregion
        }

        #region Additional functions
        //For class "Airplane"
        static string OutputWithZero(object text)
{
    try
    {
        return text.ToString().PadLeft(2).Replace(' ', '0');
    }
    catch(Exception e)
    {
        Console.WriteLine(e);
        Environment.Exit(1);
        return "1";
    }
}
        static string OutputDate(Date date)
{
    return $"{OutputWithZero(date.Hours)}:{ OutputWithZero(date.Minutes)} " +
    $"{OutputWithZero(date.Day)}.{OutputWithZero(date.Month)}.{date.Year}";
}

        #endregion
    }
}