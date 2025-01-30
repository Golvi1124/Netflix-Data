using System;
using System.Globalization;

namespace Netflix_Data.Models;

//Here we create a model for our entire file.
public class NetflixDataset
{
    // We say that the file represents a list of NetflixRows objects.
    public List<NetflixRows> AllInfo { get; set; } = [];
    // We create a constructor that reads the file, and creates a list based on the data there.
    public NetflixDataset()
    {
        /* Here we use ReadLines to read the file one line at a time, each line is separated out as its own string. */
        var rawData = File.ReadLines("netflix_titles.csv");

        /* Here we use LinQ to create the list of NetflixRows.
        We "chain" multiple methods together into a method array.
        Skip allows us to skip x number (in our case 1) elements at the start of our sequence before the next operation.
        Select says based on an arbitrary element, what to return.
        ToList() says what the result should be stored as. */
        AllInfo = rawData.Skip(1).Select(dataString => new NetflixRows(dataString)).ToList();
        //Basically the same as:
        /* var data = rawData.ToList();
        for (int i = 1; i < data.Count; i++)
        {
        AllInfo.Add(new NetflixRows(data[i]));
        } */
    }

}
/* 
public class MenyItems
{
    public List<string> GetMenyItems()
    {
        return ["Margherita", "Grandiosa", "Napoli", "Big One", "Meat Lovers"];
    }

}
------------------------------------------------------------------------------------
public class Customers
{
    public List<string> GetCustomers()
    {
        return [];
    }
}
--------------------------------------------------------------------------------------
Chat GPT...need to make sence of this...
public class NetflixDataset
{
    public List<NetflixRows> Titles { get; set; } = new List<NetflixRows>();

        public void LoadData(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                Titles = csv.GetRecords<NetflixRows>().ToList();
            }
        }
}

 */