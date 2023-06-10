using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labRyaba
{
    public interface IObserverable
    {
        void NotifyOb(int t, int p, int h);
    }
}
