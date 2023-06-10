using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labRyaba
{
    public class ThreeAxisTruck : AbstractTruck
    {
        public ThreeAxisTruck(string Name, string Engine_type, string Body_type) : base(Name)
        {
            this.body_type = Body_type;
            this.engine_type = Engine_type;
        }

        public override string GetTruckType()
        {
            return "3-х осевой";
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
