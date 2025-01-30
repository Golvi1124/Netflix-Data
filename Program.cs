// dotnet add package CsvHelper --version 33.0.1

using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using Netflix_Data.Models;

namespace Netflix_Data;

class Program
{
    static void Main(string[] args)
    {
        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            PrepareHeaderForMatch = args => args.Header.ToLower(),
        };
        using (var reader = new StreamReader("netflix_titles.csv"))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            var data = csv.GetRecords<NetflixRows>();
        }


    }
}

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