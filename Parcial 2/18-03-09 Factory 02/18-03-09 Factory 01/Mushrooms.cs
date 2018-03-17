using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_09_Factory_01
{
    class Mushrooms : Toppings
    {
        Pizza pizza;

        public Mushrooms(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public override string describe()
        {
            return pizza.describe() + ", Mushrooms";
        }
    }
}
