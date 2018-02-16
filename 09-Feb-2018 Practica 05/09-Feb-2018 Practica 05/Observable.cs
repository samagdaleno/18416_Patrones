using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Feb_2018_Practica_05
{
    abstract class Observable
    {
        List<IObserver> observerList;
        bool changed = false;

        public Observable()
        {
            this.observerList = new List<IObserver>();
        }
        public void add(IObserver observer)
        {
            this.observerList.Add(observer);
        }
        public void remove(IObserver observer)
        {
            this.observerList.Remove(observer);
        }
        public void notify(Object o)
        {
            foreach (IObserver observer in observerList)
                observer.update(this, o);
        }
    }
}
