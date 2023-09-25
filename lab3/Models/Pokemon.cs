using QueryBuilderStarter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Pokemon : IClassModel
{
    public int Id { get; set; }
    public int DexNumber { get; set; }
    public string Name { get; set; }
    public string Form { get; set; }
    public string Type1 { get; set; }
    public string Type2 { get; set; }
    public int Total { get; set; }
    public int HP { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
    public int SpecialAttack { get; set; }
    public int SpecialDefense { get; set; }
    public int Speed { get; set; }
    public int Generation { get; set; }

    public Pokemon()
    {
        this.Id = 0;
        this.DexNumber = 0;
        this.Form = string.Empty;
        this.Name = string.Empty;
        this.Type1 = string.Empty;
        this.Type2 = string.Empty;
        this.Total = 0;
        this.HP = 0;
        this.Attack = 0;
        this.Defense = 0;
        this.SpecialAttack = 0;
        this.SpecialDefense = 0;
        this.Speed = 0;
        this.Generation = 0;

    }

    public Pokemon(int Id, int DexNum, string Form, string Name, string Type, string Type2, int Total, int HP, int Attack, int Defense, int SpecialAttack, int SpecialDefense, int speed, int Generation)
    {
        this.Id = Id;
        this.DexNumber = DexNum;
        this.Form = Form;
        this.Name = Name;
        this.Type1 = Type;
        this.Type2 = Type2;
        this.Total = Total;
        this.HP = HP;
        this.Attack = Attack;
        this.Defense = Defense;
        this.SpecialAttack = SpecialAttack;
        this.SpecialDefense = SpecialDefense;
        this.Speed = speed;
        this.Generation = Generation;
    }

    public override string ToString()
    {
        string str = $"PokeDex Number {DexNumber}\n";
        str += $"Name: {Name}\n";
        str += $"Type1: {Type1}\n";
        str += $"Type2: {Type2}\n";
        str += $"Total: {Total}\n";
        str += $"HP: {HP}\n";
        str += $"Attack: {Attack}\n";
        str += $"Defense: {Defense}\n";
        str += $"SpecialAttack: {SpecialAttack}\n";
        str += $"SpecialDefense: {SpecialDefense}\n";
        str += $"Speed: {Speed}\n";
        str += $"Generation: {Generation}.";

        return str;
    }
}