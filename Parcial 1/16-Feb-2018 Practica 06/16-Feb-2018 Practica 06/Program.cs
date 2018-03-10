using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Feb_2018_Practica_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Bebida chai = new ChaiPay();
            Console.WriteLine(chai.getDescription() + ", $" + chai.cost());

            chai = new LecheAlmendras(chai);
            Console.WriteLine(chai.getDescription() + ", $" + chai.cost());

            chai = new LecheAlmendras(chai);
            Console.WriteLine(chai.getDescription() + ", $" + chai.cost());

            Console.ReadKey();
        }
    }
}
