using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_16_Command_01
{
    class Reciever
    {

        public void On() {
            Console.WriteLine("INSTRUCCIONES INTERNAS DE ON");
        }

        public void Off() {
            Console.WriteLine("INSTRUCCIONES INTERNAS DE OFF");
        }

        public void Slow()
        {
            Console.WriteLine("INSTRUCCIONES INTERNAS DE SLOW");
        }

        public void Medium()
        {
            Console.WriteLine("INSTRUCCIONES INTERNAS DE MEDIUM");
        }

        public void High()
        {
            Console.WriteLine("INSTRUCCIONES INTERNAS DE HIGH");
        }
    }
}
