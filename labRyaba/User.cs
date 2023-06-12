using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labRyaba
{
    public class User : Observerable, IObserver
    {
        private string name;

        public User(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }

        public void Update(string message)
        {
            Notify("User " + name + " has got a message \"" + message + "\"");
        }
    }
}
