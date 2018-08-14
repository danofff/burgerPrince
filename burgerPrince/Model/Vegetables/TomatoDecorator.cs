using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burgerPrince.Model.Vegetables
{
    public class TomatoDecorator : VegetableDecorator
    {
        public TomatoDecorator(Vegetable vegy) : base(vegy.Name, vegy.Price, vegy)
        {
        }
    }
}
