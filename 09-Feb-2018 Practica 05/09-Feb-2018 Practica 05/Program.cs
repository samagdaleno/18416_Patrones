using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Feb_2018_Practica_05
{
    class Program
    {
        static void Main(string[] args)
        {
            DHL dhl = new DHL();
            Fedex fedex = new Fedex();
            CorreosDeMexico cmex = new CorreosDeMexico();

            ClientA ca = new ClientA();
            ClientB cb = new ClientB();
            ClientC cc = new ClientC();

            dhl.add(ca);
            fedex.add(cb);
            cmex.add(ca);
            fedex.add(cc);
            dhl.add(cb);
            

            Console.ReadKey();
        }
    }
}
