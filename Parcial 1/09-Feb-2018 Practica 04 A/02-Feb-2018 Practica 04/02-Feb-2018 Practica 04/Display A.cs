using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Feb_2018_Practica_04
{
    class Display_A : IObserver, IDisplayable
    {
        public void update(Observable obs, Object o) {
            Weather_Data wd = (Weather_Data)o;
        }
        public void display() { }
    }
}
