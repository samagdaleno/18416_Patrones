using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Feb_2018_Practica_06
{
    class Crema : Ingredientes
    {
        public Bebida bebida;
        public Crema(Bebida bebida)
        {
            this.bebida = bebida;
        }
        public override string getDescription()
        {
            return bebida.getDescription() + ", Cream";
        }

        public override double cost()
        {
            if (bebida.size == "S")
                return bebida.cost() + 10.0;

            else if (bebida.size.Equals("M"))
                return bebida.cost() + 10.0;

            else
                return bebida.cost() + 30.0;
        }
    }
}
