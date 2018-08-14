using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burgerPrince.Model.Meat_
{
    public abstract class MeatFactory
    {
        public abstract Meat CreateMeat(string name,float price);
    }
}
