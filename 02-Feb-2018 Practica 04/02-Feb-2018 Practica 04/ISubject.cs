using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Feb_2018_Practica_04
{
    interface ISubject
    {
        void add(IObserver observer);
        void remove(IObserver observer);
        string notify(); 
    }
}
