using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burgerPrince.Model.Meat_
{
    public class Hum:Meat
    {
        public Hum(string name, float price)
        {
            Name = "Hum " + name;
            Price = price;
        }
    }
}
