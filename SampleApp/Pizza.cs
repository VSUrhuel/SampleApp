using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    public abstract class Pizza
    {
        public string Name { get; private set; }
        public PizzaBase Base { get; private set; }
        protected List<Topping> Toppings { get; set; }
        protected double Price { get; set; }
        public Pizza(string name, PizzaBase pbase)
        {
            this.Name = name;
            this.Base = pbase;
            this.Toppings = new List<Topping>();
        }
        
    }
}
