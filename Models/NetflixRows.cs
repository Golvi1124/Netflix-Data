using System;

namespace Netflix_Data.Models;
//put it into App folder. the menu part 
// Didn't add "DateAdded" column, because didn't see any use for it. 
public class NetflixRows
{
  public string ShowId { get; set; }
  public string Type { get; set; }
  public string Title { get; set; }
  public string Director { get; set; }
  public string Cast { get; set; }
  public string? Country { get; set; }
  public string ReleaseYear { get; set; }
  public string Rating { get; set; }
  public string Duration { get; set; }
  public string ListedIn { get; set; } //International TV Shows, Spanish-Language TV Shows, TV Action & Adventure
  public string Description { get; set; }

  // Here we create a constructor, which will create a NetflixRows object.
  // We take in a string, which represents a Comma Separated Values ​​string or an arbitrary line in our file. 

  public NetflixRows(string csv)
  {
    //We split the file, and assign values ​​to each property, based on the column.
    //Column number 1 is the same as index 0 in our values ​​array.
    string[] values = csv.Split(",");
    ShowId = values[0];
    Type = values[1];
    Title = values[2];
    Director = values[3];
    Cast = values[4];
    Country = values[5];
    ReleaseYear = values[7];
    Rating = values[8];
    Duration = values[9];
    ListedIn = values[10];
    Description = values[11];
  }






}

