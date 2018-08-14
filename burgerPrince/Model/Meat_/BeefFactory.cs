using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burgerPrince.Model.Meat_
{
    public class BeefFactory : MeatFactory
    {
        public override Meat CreateMeat(string name, float price)
        {
            return new Beef(name,price);
        }
    }
}
