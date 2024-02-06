using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PricedItem> items = new List<PricedItem>();
            items.Add(new PrefaPizza("Hawaiian", PizzaBase.Stuffed, 100, new List<Topping> { new Topping("Pineapple", 10), new Topping("Chesse", 12), new Topping("Ham", 5) }));
            DIYPizza d = new DIYPizza("DIY1", PizzaBase.Thincrust);
            d.AddTopping(new Topping("Chili", 6));
            d.AddTopping(new Topping("Olives", 19));
            d.AddTopping(new Topping("Pepperoni", 20));
            items.Add(d);
            items.Add(new Beverage("Mathca", BeverageSize.Large, 120));
            double tot = 0;
            foreach(var item in items)
            {
                Console.WriteLine(item);
                tot += item.ComputePrice();
            }
            Console.WriteLine("Total Cost: " + tot);
            Console.ReadKey();
        }
    }
}
