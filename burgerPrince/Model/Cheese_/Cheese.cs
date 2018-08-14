using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burgerPrince.Model.Cheese_
{
    public class Cheese : ICheese
    {
        public string Name { get; private set; }
        public float Price { get; private set; }
        public Cheese(string name, float price)
        {
            Name = name;
            Price = price;
        }
        public ICheese Clone()
        {
            return new Cheese(Name, Price); 
        }
    }
}
