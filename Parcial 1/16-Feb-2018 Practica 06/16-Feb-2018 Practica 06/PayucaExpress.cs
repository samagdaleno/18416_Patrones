using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Feb_2018_Practica_06
{
    class PayucaExpress : Bebida
    {
        public PayucaExpress()
        {
            this.size = "S";
        }
        public PayucaExpress(string size)
        {
            this.size = size;
        }
        public override string getDescription()
        {
            return this.size + " Payuca Express";
        }


        public override double cost()
        {
            return 20.0;
        }
    }
}
