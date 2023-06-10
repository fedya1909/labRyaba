using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labRyaba
{
    public class FourAxisTruck : AbstractTruck
    {
        public FourAxisTruck(string Name, string Engine_type, string Body_type) : base(Name)
        {
            this.body_type = Body_type;
            this.engine_type = Engine_type;
        }

        public override string GetTruckType()
        {
            return "2-х осевой";
        }

        public override string GetBodyType()
        {
            return base.GetBodyType();
        }

        public override string GetEngineType()
        {
            return base.GetEngineType();
        }
    }
}
