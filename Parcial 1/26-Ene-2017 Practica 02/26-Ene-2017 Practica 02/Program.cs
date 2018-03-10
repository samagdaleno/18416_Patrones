using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Ene_2017_Practica_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Troll Memilio = new Troll();
            Queen queen = new Queen();
            King king = new King();
            Knight knoght = new Knight();
            
            Memilio.setWeaponBehavior(new CrossBowBehavior());
            queen.setWeaponBehavior(new SwordBehavior());
            king.setWeaponBehavior(new KnifeBehavior());
            knoght.setWeaponBehavior(new CrossBowBehavior());
        }
    }
}
