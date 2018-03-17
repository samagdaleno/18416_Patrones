using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_09_Factory_01
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaFactory simpleF = new SimpleFactory();
            PizzaFactory mexicanF = new MexicanFactory();
            PizzaFactory meatyF = new MeatyFactory();
            PizzaStore ps1 = new PizzaStore(simpleF);
            PizzaStore ps2 = new PizzaStore(mexicanF);
            PizzaStore ps3 = new PizzaStore(meatyF);

            List<String> pizzas = new List<String> { "Pepperoni", "MeatyJohn", "Mexican" };
            foreach (String p in pizzas)
            {

                Pizza pizza1 = ps1.makePizza(p);
                pizza1 = new Mushrooms(pizza1);

                Console.WriteLine(pizza1.describe());
            }
            Console.ReadLine();
        }
    }
}
