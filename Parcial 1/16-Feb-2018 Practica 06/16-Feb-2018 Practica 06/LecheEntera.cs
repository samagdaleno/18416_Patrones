using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Feb_2018_Practica_06
{
    class LecheEntera : Ingredientes
    {
        public Bebida bebida;

        public LecheEntera(Bebida bebida)
        {
            this.bebida = bebida;
        }
        public override string getDescription()
        {
            return bebida.getDescription() + ", Whole Milk";
        }
        public override double cost()
        {
            if (bebida.size.Equals("S"))
                return bebida.cost() + 15.0;

            else if (bebida.size.Equals("M"))
                return bebida.cost() + 25.0;

            else
                return bebida.cost() + 35.0;
        }
    }
}
