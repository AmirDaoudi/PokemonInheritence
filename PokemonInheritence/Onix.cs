 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonInheritence
{
    internal class Onix : Pokemon
    {
        public Onix()
           : base("Rock", "Ground", 3, 100, 15, 22, 10)
        {

        }
        public override int Move1()
        {
            Health -= 3;
            return 15;
        }
        public override int Move2()
        {
            Health -= 6;
            return 22;
        }
        public override int Move3()
        {
            Health += 10;
            return 0;
        }
        public override string Name => "Onix";

    }
}
