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





//add readkeys 






QB.Create(KH);
Console.WriteLine($"Added {KH} to sql database banned games");
Console.ReadKey();

QB.Create(Sora);
Console.WriteLine($"Added {Sora} to sql database pokemon");
Console.ReadKey();

Console.WriteLine("Next action will delete all rows from banned games");


QB.DeleteAll<BannedGame>();



for (int i = 0; i < pokearr.Length; i++)
{
    QB.Create(pokearr[i]);
}


foreach (var pokemon in results)
{
    Console.WriteLine(pokemon);
}
















QB.Dispose();
