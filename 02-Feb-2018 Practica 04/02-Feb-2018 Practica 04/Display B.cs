using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Feb_2018_Practica_04
{
    class Display_B : IObserver, IDisplayable
    {
        public void update(int pressure, int temp, int humidity) { }
        public void display() { }
    }
}
