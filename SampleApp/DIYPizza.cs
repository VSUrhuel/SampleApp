using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    public class DIYPizza : Pizza, PricedItem
    {
        public DIYPizza(string name, PizzaBase pbase) : base(name, pbase)
        {

        }

        public void AddTopping(Topping topping)
        {
            if(this.Toppings.Contains(topping)) return;
            this.Toppings.Add(topping);
        }

        public double ComputePrice()
        {
            double totPrice = 0;
            switch(this.Base)
            {
                case PizzaBase.Thincrust:
                    totPrice = 50;
                    break;
                case PizzaBase.Regular:
                    totPrice = 80;
                    break;
                case PizzaBase.Stuffed:
                    totPrice = 150;
                    break;
            }
            foreach (var item in this.Toppings)
                totPrice += item.Price;
            return totPrice;
            
        }
        public override string ToString()
        {
            string name = this.Name + ":\n";
            foreach (var topping in this.Toppings)
                name += "\t" + topping + "\n";
            name += "=" + this.ComputePrice();
            return name;
        }
    }
}
