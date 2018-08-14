using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burgerPrince.Model.Meat_
{
    public class HumFactory : MeatFactory
    {
        public override Meat CreateMeat(string name, float price)
        {
            return new Hum(name, price);
        }
    }
}
