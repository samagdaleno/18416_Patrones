using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_09_Factory_01
{
    class Chorizo : Toppings
    {
        Pizza pizza;

        public Chorizo(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public override string describe()
        {
            return pizza.describe() + ", Chorizo";
        }
    }
}
