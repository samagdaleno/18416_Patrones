using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_09_Factory_01
{
    class PizzaMeatyJohn : Pizza
    {
        public PizzaMeatyJohn() : base()
        {
        }
        override public String describe()
        {
            return "Meaty John Pizza";
        }
    }
}
