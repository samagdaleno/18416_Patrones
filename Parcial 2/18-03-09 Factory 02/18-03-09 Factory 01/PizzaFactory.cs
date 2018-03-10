using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_09_Factory_01
{
    abstract class PizzaFactory
    {
        public PizzaFactory() { }
        public abstract Pizza createPizza(string pizzaType);
    }
}
