using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace labRyaba
{
    internal class Program
    {
        static Timer t;
        static void Main(string[] args)
        {
            

            IObserverable ob = new Device();
            Station station = new Station();

            station.add(ob);
            SetTimer(station);
            station.remove(ob);

        }

        public static void SetTimer(Station s)
        {
            t = new Timer(1000);
            s.start(10);
            t.AutoReset = true;
            t.Enabled = true;
        }
    }
}
