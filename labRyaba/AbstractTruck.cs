using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labRyaba
{
    public abstract class AbstractTruck
    {
        protected string name;
        protected string engine_type;
        protected string body_type;

        public AbstractTruck(string Name)
        {
            this.name = Name;
        }

        public string GetName() { return name; }
        public virtual string GetTruckType() { return "Для ручного согласования"; }
        public virtual string GetEngineType() { return "Для ручного согласования"; }
        public virtual string GetBodyType() { return "Для ручного согласования"; }
    }
}
