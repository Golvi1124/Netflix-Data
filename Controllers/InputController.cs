using System;
using Netflix_Data.Models;

namespace Netflix_Data.Controllers;

public class InputController(NetflixDataset dataset)
{
    /* Here we have moved the responsibility for input to a separate controller.
We retrieve a reference to our data context (to our csv file) */
    private readonly NetflixDataset _dataset = dataset;
    private bool isRunning { get; set; } = true;
    public void Run()
    {
        while (isRunning)
        {
            Console.WriteLine("Here are the controls:");
            Console.WriteLine("1: Top 10 countries represented.");
            Console.WriteLine("2: What is the ratio of Movies to Tv-series?");
            Console.WriteLine("3: How many releases per year?");
            Console.WriteLine("4: How many options based on ratings?");
            Console.WriteLine("5: Top 5 most and 5 least represented film genres.");
            Console.WriteLine("6: Longest 5 movies and Tv-shows.");
            Console.WriteLine("\nExtra options:");
            Console.WriteLine("7: Find specific movie or Tv-series.");
            Console.WriteLine("8: Need help to choose what to watch.");
            Console.WriteLine("9: ...exit program");

            var input = Console.ReadLine();
            int command;
            // Here we force the user to enter a text that can be parsed into an integer.
            while (!int.TryParse(input, out command))
            {
                Console.WriteLine("Please choose a valid command number");
                input = Console.ReadLine();
            }

            switch (command)
            {
                case 1:
                    Console.WriteLine();
                    break;

                case 2:
                    Console.WriteLine();
                    break;

                case 3:
                    Console.WriteLine();
                    break;

                case 4:
                    Console.WriteLine();
                    break;

                case 5:
                    Console.WriteLine();
                    break;

                case 6:
                    Console.WriteLine();
                    break;

                case 7:
                    var query = QueryBuilder();
                    Console.WriteLine();
                    foreach (var data in query)
                    {
                        Console.WriteLine($"");
                    }
                    break;

                    case 8:
                    query = QueryBuilder();
                    Console.WriteLine();
                    foreach (var data in query)
                    {
                        Console.WriteLine($"");
                    }
                    break;

                    default:
                    isRunning = false;
                    break;

            }

        }
    }

    /* Here we create a LinQ interface, which will eventually "consume" and display a result to the user.
We see again here that we can "chain" the methods as much as we want to see if the user wants to query against 
Age, against PrimaryFurColor or both, or neither.  */

    public IQueryable<NetflixRows> QueryBuilder()
    {
        var queryStart = _dataset.AllInfo.AsQueryable();
    }
}


/* 

Querry through: movie/tvshow, year range, actor name? director or better Listed in? ....to find specific movie
Querry through: type, rating(how old is youngest watcher), listed in => description added ...to help choose a movie


Menu:
- print all categories
 */

/* 
public class CustomerController(Customers customers, RenderCustomers view)
{
    ....Denne controlleren skal styre hvordan vår app skal interacte med vår customer modell. 
    private readonly List<string> _customers = customers.GetCustomers();
    private readonly RenderCustomers _view = view;
    public void AddCustomer()
    {
        Console.WriteLine("Please enter a valid name");
        var input = Console.ReadLine();
        while (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Name was not valid, please try again");
            input = Console.ReadLine();
        }
        _customers.Add(input);
    }
    public void DisplayCustomers()
    {
        _view.DisplayCustomers(_customers);
    }
    public void RemoveCustomer()
    {   
        Console.WriteLine("Please enter a valid name");
        var input = Console.ReadLine();
        while (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Name was not valid, please try again");
            input = Console.ReadLine();
        }
        _customers.Remove(input);
    }
}

...Denne controlleren styrer hvordan vår app skal interacte med vår meny modell. 
public class MenyController (MenyItems meny, RenderMeny view)
{
    private readonly RenderMeny _view = view;
    private readonly List<string> _meny = meny.GetMenyItems();
    public void GetAllMenyItems()
    {
        _view.DisplayMeny(_meny);
    }
    public void IsPizzaAvaliable()
    {
        var input = Console.ReadLine();
        _view.DisplayAvailability(input, _meny.Contains(input));
    }

}

 */




/* 
private readonly NetflixDataset _dataset;

        public NetflixController(string filePath)
        {
            _dataset = new NetflixDataset();
            _dataset.LoadData(filePath);
        }

        public Dictionary<string, int> GetTypeCounts()
        {
            return _dataset.Titles.GroupBy(t => t.Type).ToDictionary(g => g.Key, g => g.Count());
        }

        public Dictionary<int, int> GetMoviesPerYear()
        {
            return _dataset.Titles.Where(t => int.TryParse(t.ReleaseYear, out _))
                                  .GroupBy(t => int.Parse(t.ReleaseYear))
                                  .ToDictionary(g => g.Key, g => g.Count());
        }

        public Dictionary<string, int> GetTop10Actors()
        {
            return _dataset.Titles.Where(t => !string.IsNullOrEmpty(t.Cast))
                                  .SelectMany(t => t.Cast.Split(','))
                                  .Select(actor => actor.Trim())
                                  .GroupBy(actor => actor)
                                  .OrderByDescending(g => g.Count())
                                  .Take(10)
                                  .ToDictionary(g => g.Key, g => g.Count());
        }

        public bool CheckAvailability(string title)
        {
            return _dataset.Titles.Any(t => t.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }

        public int GetCountryCount()
        {
            return _dataset.Titles.Where(t => !string.IsNullOrEmpty(t.Country))
                                  .SelectMany(t => t.Country.Split(','))
                                  .Select(country => country.Trim())
                                  .Distinct()
                                  .Count();
        }
 */