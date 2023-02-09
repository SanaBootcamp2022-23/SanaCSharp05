using OOP1;

class Program
{


    static void Main(string[] args)
    {
            
        Airplane testAirplane = new Airplane("Kiev","Lviv",2022,12,28,2022,12,28,22,20,23,44);
        testAirplane.GetTotalInfo();

        Console.WriteLine();

        Product testProduct = new Product("Кавун", 2, "Доллар", (float)37.45, 4, "ТОВ Херсон", 5);
        testProduct.GetTotalInfo();
    }
}