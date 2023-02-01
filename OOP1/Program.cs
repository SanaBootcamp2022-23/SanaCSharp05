using OOP1;

///first class
Airplane airplane = new Airplane("Kiev", "Chop",new (2023,1,30,7,15),new (2023,1,30,13,11));
string arivingToday;
if (airplane.IsArrivingToday())
{
    arivingToday = "Yes";
}
else
{
    arivingToday = "No";
}
Console.Write(
    "\n"+
    $"    From: {airplane.StartCity}\n"+
    $"    To: {airplane.FinishCity}\n"+
    $"    Start: {airplane.StartDate.GetYear}.{airplane.StartDate.GetMonth}.{airplane.StartDate.GetDay} {airplane.StartDate.GetHour}:{airplane.StartDate.GetMinute}\n"+
    $"    Landing: {airplane.FinishDate.GetYear}.{airplane.FinishDate.GetMonth}.{airplane.FinishDate.GetDay} {airplane.FinishDate.GetHour}:{airplane.FinishDate.GetMinute}\n"+
    $"    Took time: {airplane.GetTotalTime()} minuts\n" +
    $"    Is arriving today: {arivingToday}\n"
    );


//second class
Airplane airplane1 = new Airplane(airplane);
Product product = new Product("Laptop",1800,new("USD",36.5),10,"Lenovo",3.4);

Console.Write(
    $"\n    Name: {product.Name} \n" +
    $"    Price: {product.Price} {product.Cost.NameVal} \n" +
    $"    Produser: {product.Producer} pieces\n" +
    $"    Price in UAH: {product.GetPriceInUAH()} UAH\n" +
    $"    Weight: {product.Weight} KGs \n" +
    $"    Quantity: {product.Quantity} \n"+
    $"    Total Weight: {product.GetTotalWeight()} KGs \n" +
    $"    Total Price: {product.GetTotalPriceInUAH()} UAH \n"
    );
