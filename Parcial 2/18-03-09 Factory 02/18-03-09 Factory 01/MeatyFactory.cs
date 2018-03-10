﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_09_Factory_01
{
    class MeatyFactory : PizzaFactory
    {
        public override Pizza createPizza(string pizzaType)
        {
            return new PizzaMeatyJohn();
        }
    }
}
