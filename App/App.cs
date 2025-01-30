using System;
using Netflix_Data.Controllers;

namespace Netflix_Data.App;

/* public class LaPizzeriaApp(MenyController menyController, CustomerController customerController)
{
    ...Appen må ha en referanse til hver av controllerene den skal styre. 
    private readonly MenyController _menyController = menyController;
    private readonly CustomerController _customerController = customerController;

    ...Den har et eget felt som ser om appen skal kjøre 
    private bool isRunning = true;

    ...Her er metoden som kjører vår app. 
    public void Run()
    {
        while (isRunning)
        {
            Console.WriteLine("Welcome to La Pizzeria");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("press 1 for registering a new customer");
            Console.WriteLine("press 2 for unregistering a new customer");
            Console.WriteLine("press 3 to see the available meny");
            Console.WriteLine("press 4 to check availability of an item");
            Console.WriteLine("press 5 to exit.");
            ...Her tar appen imot brukerinput, og sier til kontrolleren vår hva som skal kjøres. 
            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    _customerController.AddCustomer();
                    break;
                case "2":
                    _customerController.RemoveCustomer();
                    break;
                case "3":
                    _menyController.GetAllMenyItems();
                    break;
                case "4":
                    _menyController.IsPizzaAvaliable();
                    break;
                case "5":
                    Console.WriteLine("Exiting...");
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Not supported");
                    break;
            }
        }
    }

}
 */







/* public class App
{
    private bool isRunning = true;
    private NetflixController _controller;

    public App(string filePath)
    {
        _controller = new NetflixController(filePath);
    }

    public void Run()
    {
        while (isRunning)
        {
            Console.WriteLine("Welcome to Netflix data set");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("Press 1 for showing how many types there are and how many in each");
            Console.WriteLine("Press 2 for showing how many movies were released in each year");
            Console.WriteLine("Press 3 to see top 10 Actors who are in list with count");
            Console.WriteLine("Press 4 to check availability of an item");
            Console.WriteLine("Press 5 to see from how many countries");
            Console.WriteLine("Press 6 to exit");

            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    foreach (var type in _controller.GetTypeCounts())
                    {
                        Console.WriteLine($"{type.Key}: {type.Value}");
                    }
                    break;
                case "2":
                    foreach (var year in _controller.GetMoviesPerYear().OrderBy(y => y.Key))
                    {
                        Console.WriteLine($"{year.Key}: {year.Value}");
                    }
                    break;
                case "3":
                    foreach (var actor in _controller.GetTop10Actors())
                    {
                        Console.WriteLine($"{actor.Key}: {actor.Value}");
                    }
                    break;
                case "4":
                    Console.Write("Enter the title to check: ");
                    string title = Console.ReadLine();
                    Console.WriteLine(_controller.CheckAvailability(title) ? "Available" : "Not Available");
                    break;
                case "5":
                    Console.WriteLine($"Total number of countries: {_controller.GetCountryCount()}");
                    break;
                case "6":
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid input, try again.");
                    break;
            }
        }
    }
}
 */