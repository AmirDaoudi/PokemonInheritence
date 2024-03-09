using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonInheritence
{
    internal class PrimeApe : Pokemon
    {
        public PrimeApe()
            : base("Fighting", "", 3, 80, 15, 30, 10)
        {

        }
        public override int Move1()
        {
            Health -= 5;
            return 15;
        }
        public override int Move2()
        {
            Health -= 10;
            return 30;
        }
        public override int Move3()
        {
            Health += 10;
            return 0;
        }
        public override string Name => "PrimeApe";
    }
}