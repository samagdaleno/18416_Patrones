using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Feb_2018_Practica_04
{
    class Weather_Data : ISubject
    {
        public List<IObserver> observerList;
        public int temperature, pressure, humidity;


        public void setMeasurements(int pressure, int temp, int humidity) {
            this.pressure = pressure;
            this.temperature = temp;
            this.humidity = humidity;
        }

        public int getTemperature() { return this.temperature; }
        public int getPressure() { return this.pressure; }
        public int getHumidity() { return this.humidity; }
        public bool measurementChanged() { return true; }


        public void add(IObserver observer) { }
        public void remove(IObserver observer) { }
        public string notify() {
            foreach (IObserver observer in observerList)
                observer.update(this.pressure, this.temperature, this.humidity);

            return null;
        }

    }
}
