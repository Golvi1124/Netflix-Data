using System;
using Netflix_Data.Models;

namespace Netflix_Data.Controllers;

public class NetflixController
    {
        
    }

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