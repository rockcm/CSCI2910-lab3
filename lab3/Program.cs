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

var results = QB.ReadAll<Pokemon>();
var GameResults = QB.ReadAll<BannedGame>();

Pokemon Zelda = new Pokemon(1046, 999, " ", "Zelda", "poison", "flying", 0, 0, 0, 0, 0, 0, 0, 0);
Pokemon Mario = new Pokemon(1047, 1000, " ", "Mario", "poison", "flying", 0, 0, 0, 0, 0, 0, 0, 0);

Pokemon Sora = new Pokemon(1048, 1001, " ", "Sora", "poison", "flying", 0, 0, 0, 0, 0, 0, 0, 0);

Pokemon[] pokearr = { Zelda, Mario };

BannedGame BadGame = new BannedGame(1000, "Kingdom Hearts", "KH3", "USA", "Test Ban" );

//QB.Create(BadGame);

QB.DeleteAll<BannedGame>();



/*

QB.Create(BadGame);




for(int i = 0; i < pokearr.Length; i++)
{
    QB.Create(pokearr[i]);
}


foreach (var pokemon in results)
{
    Console.WriteLine(pokemon);
}



QB.Delete(Zelda);


QB.Create(Zelda);

QB.Dispose();
*/