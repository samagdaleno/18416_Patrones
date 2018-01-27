using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Ene_2017_Practica_02
{
    class Troll : Character
    {
        public Troll () : base() { }
        public override void fight()
        {
            weapon.useWeapon();
        }
    }
}
