using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Feb_2018_Practica_05
{
    interface IObserver
    {
        void update(Observable obs, Object o);
    }
}
