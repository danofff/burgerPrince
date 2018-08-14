using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burgerPrince.Model.Vegetables
{
    public abstract class VegetableDecorator : Vegetable
    {
        protected Vegetable Vegy;
        public VegetableDecorator(string name, float price, Vegetable vegy) : base(name, price)
        {
            Vegy = vegy;
        }
    }
}
