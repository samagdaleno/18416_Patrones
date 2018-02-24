using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Feb_2018_Practica_06
{
    public abstract class Bebida
    {
        public string size { get; set; }
        public abstract string getDescription(); 
        public abstract double cost();
    }
}
