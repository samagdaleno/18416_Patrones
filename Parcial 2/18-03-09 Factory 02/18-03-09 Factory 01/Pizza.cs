using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_09_Factory_01
{
    abstract class Pizza
    {
        public Pizza() { }
        public void cut() { }
        public void box() { }
        public void bake() { }
        public void garnish() { }
    }
}
