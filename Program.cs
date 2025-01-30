// dotnet add package CsvHelper --version 33.0.1
//base for everything is mix from lectures
//using data taken from: https://www.kaggle.com/datasets/padmapriyatr/netflix-titles

namespace Netflix_Data;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;

using Netflix_Data.Models;
using Netflix_Data.Controllers;



class Program
{
    static void Main(string[] args)
    {
      // Here we create an instance of our data NetflixDataset, the one that will be our model of the file itself.
        var dataset = new NetflixDataset();
        Console.WriteLine("Welcome to the Netflix data base!");
        var controller = new InputController(dataset);
        controller.Run();
    }
}



/*   var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            PrepareHeaderForMatch = args => args.Header.ToLower(),
        };
        using (var reader = new StreamReader("netflix_titles.csv"))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            var data = csv.GetRecords<NetflixRows>();
        } */


/* 
static void Main(string[] args)
    {
        ....Her configurerer og initialiserer vi alt som skal brukes av appen 

        ...Her lager vi en måte å hente modeller for de forskjellige dataene vi skal ha oversikt over 
        var meny = new MenyItems();
        var customers = new Customers();


        ....Her lager vi metoder for å vise views av dataen vår på 
        var menyDisplayer = new RenderMeny();
        var customerDisplayer = new RenderCustomers();

        ....Her lager vi controllere som skal bruke input, og kjøre actions mot modellene våre 
        var menyController = new MenyController(meny, menyDisplayer);
        var customerController = new CustomerController(customers, customerDisplayer);

        ....Vi lager så en instans av vår app, som tar inn bruker input og sender input til rett controller 
        var app = new LaPizzeriaApp(menyController, customerController);
        
        .....Her kjøer vi appen vår. 
        app.Run();
    }
    
 */