using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using QueryBuilderStarter;


public class BannedGame : IClassModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Series { get; set; }
    public string Country { get; set; }
    public string Details { get; set; }
   
   

    public BannedGame()
    {
        this.Id = 0;
        this.Country = string.Empty;
        this.Series = string.Empty;
        this.Title = string.Empty;
        this.Details = string.Empty;

    }

    public BannedGame(int Id, string Series, string Title, string Country, string Details)
    {
        this.Id = Id;
        this.Series = Series;
        this.Title = Title;
        this.Country = Country;
        this.Details = Details;

    }

    public override string ToString()
    {
        string str = $"Series {Series},";
        str += $"Series {Title},";
        str += $"Series {Details}.";
        return str;

    }
}

