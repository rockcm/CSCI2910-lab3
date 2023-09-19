using QueryBuilderStarter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



string path;
path = "../../../Data/data.db";
QueryBuilder QB = new QueryBuilder(path);

var results = QB.ReadAll<Pokemon>();

Pokemon Zelda = new Pokemon(1046, 999, " ", "Zelda", "poison", "flying", 0, 0, 0, 0, 0, 0, 0, 0);


foreach (var pokemon in results)
{
    Console.WriteLine(pokemon);
}


//QB.Delete(Zelda);


//QB.Create(Zelda);

QB.Dispose();