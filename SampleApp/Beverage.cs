using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    public class Beverage : PricedItem
    {
        public string Name { get; private set; }
        public double Price { get; private set; } 
        public BeverageSize Size { get; private set; }
        public Beverage(string name, BeverageSize size, double basePrice)
        {
            this.Name = name;
            this.Size = size;
            this.Price = basePrice;
        }
        public double ComputePrice()
        {
            switch(this.Size)
            {
                case BeverageSize.Mini:
                    return this.Price * 0.7;
                case BeverageSize.Large:
                    return this.Price * 1.5;
                default:
                    return this.Price;
            }
        }
        public override string ToString()
        {
            return this.Name + " (" + this.Size + ") = " + this.ComputePrice();
        }
    }
    
}
