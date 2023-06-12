using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labRyaba
{
    public abstract class Pizzeria
    {
        protected OrderOptions orderOptions;

        public void doOrder(OrderOptions orderOptions)
        {
            setOrderOptions(orderOptions);
            getPayment();
            makePizza();
        }

        protected abstract void makePizza();

        protected abstract void getPayment();

        protected void setOrderOptions(OrderOptions orderOptions)
        {
            this.orderOptions = orderOptions;
        }
    }
}
