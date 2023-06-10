using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labRyaba
{
    public class Device : IObserverable
    {
        int temp;
        int press;
        int hum;
        public void NotifyOb(int t, int p, int h)
        {
            if(t == temp && p == press && h == hum)
            {
                Console.WriteLine("");
            }

            if (t != temp)
            {
                Console.WriteLine("Температура изменилась: " + t);
                temp = t;
            }
            if (p != press)
            {
                Console.WriteLine("Давление изменилось: " + p);
                press = p;
            }
            if (h != hum)
            {

                Console.WriteLine("Влажность изменилась: " + h);
                hum = h;
            }
        }
    }
}
