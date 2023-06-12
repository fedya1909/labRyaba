using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labRyaba
{
    internal class Observerable : IObservable
    {
        private List<IObserver> observers = new List<IObserver>();

        
        public void Attach(IObserver observer)
        {
            if (observer != null)
            {
                observers.Add(observer);
            }
        }

       
        public void Detach(IObserver observer)
        {
            if (observer != null)
            {
                observers.Remove(observer);
            }
        }

        public void DetachObserverByName(String name)
        {
            observers.RemoveAt(// хз как эту строчку переписать element->element.GetName().equals(name));
        }

        public void Notify(String message)
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(message);
            }
        }
    }
}
