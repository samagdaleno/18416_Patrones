using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Feb_2018_Practica_06
{
    class PayeLatte : Bebida
    {
        public PayeLatte()
        {
            this.size = "S";
        }
        public PayeLatte(string size)
        {
            this.size = size;
        }
        public override string getDescription()
        {
            return this.size + " Paye Latte";
        }


        public override double cost()
        {
            return 30.0;
        }

    }
}
