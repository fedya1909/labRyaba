using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labRyaba
{
    public interface IObservable
    {
        void Attach(IObserver observer);
        // Удалить наблюдателя.
        void Detach(IObserver observer);
        // Удалить наблюдателя по имени.
        void DetachObserverByName(string name);
        // Оповестить наблюдателей.
        void Notify(string message);
    }
}
