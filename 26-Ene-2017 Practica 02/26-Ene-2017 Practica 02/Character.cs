using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Ene_2017_Practica_02
{
    abstract class Character
    {
        public WeaponBehavior weapon { get; set; }

        public abstract void fight();
   
        public void setWeaponBehavior(WeaponBehavior wb) { }
    }
}
