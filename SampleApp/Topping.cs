using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    public class Topping
    {
        public string Name { get; private set; }
        public double Price { get; private set; }
        public Topping(string name, double price) 
        {
            this.Name = name;
            this.Price = price;
        }
        public override string ToString()
        {
            return this.Name + " (" + this.Price + ")";
        }
    }
}
