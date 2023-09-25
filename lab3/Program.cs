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




QB.Create(KH);
Console.WriteLine($" {KH} Added to sql database banned games");
Console.ReadKey();

QB.Create(Sora);
Console.WriteLine($" {Sora} Added to sql database pokemon, press any key to continue. ");
Console.ReadKey();


for (int i = 0; i < pokearr.Length; i++)
{
    QB.Create(pokearr[i]);
    Console.WriteLine($" {i} added to the sql library.");
}




Console.WriteLine("Next press will delete all rows from banned games, press any key to continue. ");
Console.ReadKey();

QB.DeleteAll<BannedGame>();

Console.WriteLine("All games deleted from banned games, press any key to continue. ");
Console.ReadKey();




/*
foreach (var pokemon in results)
{
    Console.WriteLine(pokemon);
}

foreach (var game in GameResults)
{
    Console.WriteLine(game);
}
*/ 












QB.Dispose();
