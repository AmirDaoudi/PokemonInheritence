using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonInheritence
{
    internal class Charizard : Pokemon
    {
        public Charizard()
            : base("Fire", "Flight", 3, 100, 12, 22, 10)
        {

        }
        public override int Move1()
        {
            Health -= 5;
            return 12;
        
        }
        public override int Move2()
        {
            Health -= 10;
            return 22;
        }
        public override int Move3()
        {
            Health += 10;
            return 0;
        }
        public override string Name => "Charizard"; 
             
        
    }
}
