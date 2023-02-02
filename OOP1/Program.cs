// See https://aka.ms/new-console-template for more information
using OOP1;
Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Date startDate = new Date();
Date finishDate = new Date(2023, 5, 10);
Airplane airplane = new Airplane("Житомир", "New-York",startDate,finishDate);
Console.WriteLine($"Інформація про подорож:\n\tМіто відправлення -> {airplane.GetStartCity()}" +
 $"\n\tМісто прибуття -> {airplane.GetFinishCity()}\n\tДата відправлення -> {airplane.GetStartDate().GetYear()}" +
 $"/{airplane.GetStartDate().GetMonth()}/{airplane.GetStartDate().GetDay()}\n\tДата прибуття -> {airplane.GetFinishDate().GetYear()}/" +
 $"{airplane.GetFinishDate().GetMonth()}/{airplane.GetFinishDate().GetDay()}");


airplane.SetFinishCity("Токіо");
airplane.SetFinishDate(new Date(2023, 8, 10));
airplane.SetStartDate(new Date(2023, 7, 10));
Console.WriteLine($"\nІнформація про подорож після зміни даних:\n\tМіто відправлення -> {airplane.GetStartCity()}" +
 $"\n\tМісто прибуття -> {airplane.GetFinishCity()}\n\tДата відправлення -> {airplane.GetStartDate().GetYear()}" +
 $"/{airplane.GetStartDate().GetMonth()}/{airplane.GetStartDate().GetDay()}\n\tДата прибуття -> {airplane.GetFinishDate().GetYear()}/" +
 $"{airplane.GetFinishDate().GetMonth()}/{airplane.GetFinishDate().GetDay()}");

Console.WriteLine($"\nЗагальний час подорожі -> {airplane.GetTotalTime()} хвилин.");
Console.WriteLine($"Чи відбувся початок і кінець подорожі в один день -> {airplane.IsArrivingToday()}");