using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Feb_2018_Practica_05
{
    class ClientB : IObserver
    {
        List<string> providers = new List<string>();
        public ClientB() { }
        public void update(Observable obs, Object o)
        {
            String message = o.ToString();
            display(message);
        }

        public void display(String message)
        {
            Console.WriteLine("Client B:" + message);
        }
    }
}
