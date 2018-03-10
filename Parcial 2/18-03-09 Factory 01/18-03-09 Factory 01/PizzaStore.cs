using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_09_Factory_01
{
    class PizzaStore
    {
        private PizzaFactory factory;

        public PizzaStore(PizzaFactory factory) {
            this.factory = factory;
        }

        public Pizza makePizza(String pizzaType) {
            return this.factory.createPizza(pizzaType);
        }
    }
}
