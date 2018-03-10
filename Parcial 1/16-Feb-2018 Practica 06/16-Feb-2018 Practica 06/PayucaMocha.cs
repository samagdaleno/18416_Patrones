using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Feb_2018_Practica_06
{
    class PayucaMocha : Bebida
    {
        public PayucaMocha()
        {
            this.size = "S";
        }
        public PayucaMocha(string size)
        {
            this.size = size;
        }
        public override string getDescription()
        {
            return this.size + " Payuca Mocha";
        }


        public override double cost()
        {
            return 85.50;
        }
    }
}
