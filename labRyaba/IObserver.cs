using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labRyaba
{
    public interface IObserver : IHavingName
    {
        void Update(string message);
    }
}
