using System;
using System.Globalization;

namespace Netflix_Data.Models;

public class NetflixDataset
{
    
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