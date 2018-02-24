using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Feb_2018_Practica_06
{
    class ChaiPay : Bebida
    {
        public ChaiPay()
        {
            size = "S";
        }
        public ChaiPay(string size)
        {
            this.size = size;
        }
        public override string getDescription()
        {
            return size + " Chai Pai";
        }


        public override double cost()
        {
            if (this.size.Equals("S"))
                return 10.0;

            else if (this.size.Equals("M"))
                return 20.0;

            else
                return 30.0;
        }
    }
}
