using QueryBuilderStarter;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



string path;
path = "../../../Data/data.db";
QueryBuilder QB = new QueryBuilder(path);



//variables 

var results = QB.ReadAll<Pokemon>();
var GameResults = QB.ReadAll<BannedGame>();
Pokemon Zelda = new Pokemon(1046, 999, " ", "Zelda", "poison", "flying", 1, 2, 3, 4, 5, 6, 7, 8);
Pokemon Mario = new Pokemon(1047, 1000, " ", "Mario", "poison", "flying", 0, 0, 0, 0, 0, 0, 0, 0);
Pokemon Sora = new Pokemon(1048, 1001, " ", "Sora", "poison", "flying", 0, 0, 0, 0, 0, 0, 0, 0);
Pokemon[] pokearr = { Zelda, Mario };
BannedGame KH = new BannedGame(1000, "Kingdom Hearts", "KH3", "USA", "Test Ban" );
BannedGame FF = new BannedGame(1001, "Final Fantasy", "FFVII", "Canada", "Good Game");
BannedGame W = new BannedGame(1002, "Withcer", "Witcher 3", "Canada", "Best game");

BannedGame[] GameArr = {FF, W};



Console.WriteLine("Next press will delete all rows from banned games, press any key to continue. ");
Console.ReadKey();

QB.DeleteAll<BannedGame>();
Console.WriteLine("All games deleted from banned games, press any key to continue. ");
Console.ReadKey();

QB.Create(KH);
Console.WriteLine($" {KH} Added to sql database banned games");
Console.ReadKey();

QB.Create(Sora);
Console.WriteLine($" {Sora} Added to sql database pokemon, press any key to continue. ");
Console.ReadKey();
Console.WriteLine("Next a collection of pokemon will be added to the DB. ");
Console.ReadKey();


for (int i = 0; i < pokearr.Length; i++)
{
    QB.Create(pokearr[i]);
    Console.WriteLine($" {i} added to the sql library.");
}



Console.WriteLine("Next a collection of banned games will be added to the DB. ");
Console.ReadKey();
for (int i = 0; i < GameArr.Length; i++)
{
    QB.Create(GameArr[i]);
    Console.WriteLine($"{i} added to sql library");
}


// not used, excell sheet only for if you mess up DB. 

/*
List<Pokemon> pokemonList = new List<Pokemon>();

string filePath = ""; 
string[] lines = File.ReadAllLines(filePath);

foreach (string line in lines.Skip(1)) 
{
    string[] data = line.Split(',');

    Pokemon pokemon = new Pokemon
    {
        Id = int.Parse(data[0]),
        DexNumber = int.Parse(data[1]),
        Name = data[2],
        Form = data[3],
        Type1 = data[4],
        Type2 = data[5],
        Total = int.Parse(data[6]),
        HP = int.Parse(data[7]),
        Attack = int.Parse(data[8]),
        Defense = int.Parse(data[9]),
        SpecialAttack = int.Parse(data[10]),
        SpecialDefense = int.Parse(data[11]),
        Speed = int.Parse(data[12]),
        Generation = int.Parse(data[13])
    };

    pokemonList.Add(pokemon);
}
*/








QB.Dispose();
