using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Feb_2018_Practica_04
{
    class Weather_Data : Observable
    {

        public int temperature, pressure, humidity;


        public void setMeasurements(int pressure, int temp, int humidity) {
            this.pressure = pressure;
            this.temperature = temp;
            this.humidity = humidity;

            measurementChanged();
        }

        public int getTemperature() { return this.temperature; }
        public int getPressure() { return this.pressure; }
        public int getHumidity() { return this.humidity; }
        public void measurementChanged() {
            int[] newMeasurements = new int[3];
            newMeasurements[0] = temperature;
            newMeasurements[1] = pressure;
            newMeasurements[2] = humidity;

            notify(newMeasurements);
        }




    }
}
