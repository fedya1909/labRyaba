using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labRyaba
{
    public class SomePizzeria : Pizzeria
    {

        protected override void getPayment()
        {
            Console.WriteLine("Make pizzeria: " + orderOptions.toString());
        }

        protected override void makePizza()
        {
            Console.WriteLine("Get paid");
        }
    }
}
