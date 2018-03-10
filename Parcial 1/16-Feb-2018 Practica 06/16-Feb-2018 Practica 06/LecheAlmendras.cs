using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Feb_2018_Practica_06
{
    class LecheAlmendras : Ingredientes
    {
        public Bebida bebida;
        public LecheAlmendras(Bebida bebida)
        {
            this.bebida = bebida;
            Console.WriteLine("COnstructor "+this.bebida.getDescription() +" - "+ this.size);
        }
        public override string getDescription()
        {
            return bebida.getDescription() + ", leche almendra";
        }

        public override double cost()
        {
            
            if (this.size.Equals("S"))
                return bebida.cost() + 10.0;

            else if (this.size.Equals("M"))
                return bebida.cost() + 10.0;

            else
                return bebida.cost() + 30.0;
        }
    }
}
