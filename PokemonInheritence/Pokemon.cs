using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonInheritence
{

    //makse abstract pokemon class with:
    //abstract string type
    //abstract string secondary type
    //abstract function for each of 4 moves
    internal abstract class Pokemon
    {
        public string Type { get; set; }
        public string SecondaryType { get; set; }
        public int NumAbilities { get; set; }
        public int Health { get; set; }
        public int HealthAddition { get; set; }
        public int Damage1 { get; set; }
        public int Damage2 { get; set; }
        public abstract string Name { get; }
        public abstract int Move1();
        public abstract int Move2();
        public abstract int Move3();
        public string Print() => $"{Name} is a {Type} type with {Health} health.";
        public string HealthCheck() => $"{Name} has {Health} health";
        public string MoveDisplay() => $"{Name} has 3 moves move 1 does {Damage1} Damage, move 2 does {Damage2} Damage, and move 3 gives {HealthAddition} health.\nWhich move would you like to choose 1 2 or 3";

        public Pokemon(string Type, string Type2, int NumAbilities, int Health, int Damage1, int Damage2, int HealthAddition)
        {
            this.Type = Type;
            SecondaryType = Type2;
            this.NumAbilities = NumAbilities;
            this.Health = Health;
            this.Damage1 = Damage1;
            this.Damage2 = Damage2; 
            this.HealthAddition = HealthAddition;
        }
    }
}