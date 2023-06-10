﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace labRyaba
{
    
    public class Station
    {
        static Timer t;
        private List<IObserverable> ob;

        public Station()
        {
            ob = new List<IObserverable>();
        }

        
        public void add(IObserverable o) { ob.Add(o); }
        public void remove(IObserverable o) { ob.Remove(o); }

        protected void NotifyAll( int t, int p, int h)
        {
            foreach (var o in ob)
            {
                o.NotifyOb(t, p, h);
            }
        }

        private int getRandomInRange(Random random, int min, int max)
        {
            return random.Next(max - min) + min;
        }

        public void start(int times)
        {
            Random random = new Random();

            for (int i = 0; i < times; i++)
            {
                NotifyAll(getRandomInRange(random, -25, 30), getRandomInRange(random, 10, 100),
                        getRandomInRange(random, 10, 100));
            }
            SetTimer();
        }
        public static void SetTimer()
        {
            t = new Timer(10000000);
            //t.AutoReset = true;
            //t.Enabled = true;
        }

    }
    
}
