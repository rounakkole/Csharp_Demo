using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofeeMakerDemo
{
    public class StarBucks : IMakeACoffee
    {
        public bool CheckIngredientAvailability()
        {
            return true;
        }

        public string CoffeeMaking(int sugerPerSpoon, int CoffeePack)
        {
            return "Your Order is received.";
        }
    }

    public class StubStarbucks : IMakeACoffee
    {
        public bool CheckIngredientAvailability()
        {
            return true;
        }

        public string CoffeeMaking(int sugerPerSpoon, int CoffeePack)
        {
            return "Your order is received.";
        }
    }

}
