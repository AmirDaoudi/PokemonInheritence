using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonInheritence
{
    internal class Jynx : Pokemon
    {
        public Jynx()
           : base("Ice", "Psychic", 3, 100, 10, 18, 10)
        {

        }
        public override int Move1()
        {
            Health -= 3;
            return 10;
        }
        public override int Move2()
        {
            Health -= 6;
            return 18;
        }
        public override int Move3()
        {
            Health += 10;               
            return 0;
        }
        public override string Name => "Jynx";
    }
}
