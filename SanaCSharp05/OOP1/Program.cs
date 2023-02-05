// See https://aka.ms/new-console-template for more information
using OOP1;
using System.Text;
Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Airplane airplane = new Airplane("Zhytomyr","Lviv",new Date(2023, 2, 10, 14, 45),new Date(2023, 2, 10, 16, 30));
Console.WriteLine(  $"Airplane:" +
                    $"\n\ttFrom:        {airplane.StartCity}" +
                    $"\n\tTo:           {airplane.FinishCity}" +
                    $"\n\tStart time:   {airplane.StartDate}" +
                    $"\n\tFinish time:  {airplane.FinishDate}" +
                    $"\n\tTotal time:   {airplane.GetTotalTime()}"
                  );