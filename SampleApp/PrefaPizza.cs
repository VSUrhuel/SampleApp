using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    public class PrefaPizza : Pizza, PricedItem
    {
        public PrefaPizza(string name, PizzaBase pbase, double price, List<Topping> toppings) : base(name, pbase)
        {
            this.Price = price;
            foreach(var topping in toppings)
            {
                this.Toppings.Add(topping);
            }
        }
        public double ComputePrice()
        {
            return this.Price;
        }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
