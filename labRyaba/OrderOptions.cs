using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labRyaba
{
    public class OrderOptions
    {
        private PizzaType type;
        private bool acute;
        private string ingredients;
        public OrderOptions(PizzaType type,bool acute, string ingredients)
        {
            this.type = type;
            this.acute = acute;
            this.ingredients = ingredients;
        }
        public string toString()
        {
            return "{" +
                    "type=" + type +
                    ", acute=" + acute +
                    ", ingredients=" + ingredients +
                    '}';
        }
    }
}
