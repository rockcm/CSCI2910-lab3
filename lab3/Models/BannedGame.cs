using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using QueryBuilderStarter;


public class BannedGame : IClassModel
{

    public string Series { get; set; }
    public string Game { get; set; }
    public string Description { get; set; }
    public string country { get; set; }
    public int Id { get; set; }

    public BannedGame()
    {
        this.Id = 0;
        this.country = string.Empty;
        this.Series = string.Empty;
        this.Game = string.Empty;
        this.Description = string.Empty;

    }

    public BannedGame(int Id, string series, string game, string country, string description)
    {
        this.Id = Id;
        this.Series = series;
        this.Game = game;
        this.Description = description;

    }

    public override string ToString()
    {
        string str = $"Series {Series}\n";
        str += $"Series {Game}\n";
        str += $"Series {Description}\n";
        return str;

    }
}

