using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace _09_Feb_2018_Practica_05
{
    class DHL : Observable
    {
        System.Timers.Timer aTimer = new System.Timers.Timer();
        String message = "DHL Update";

        public DHL()
        {
            aTimer.Elapsed += new ElapsedEventHandler(dailyUpdate);
            aTimer.Interval = 5000;
            aTimer.Enabled = true;
        }

        public void dailyUpdate(object source, ElapsedEventArgs e)
        {
            notify(message);
        }
    }
}
