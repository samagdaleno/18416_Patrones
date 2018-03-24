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
    }
}
