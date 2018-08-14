using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burgerPrince.Model.Vegetables
{
    public class OnionDecorator : VegetableDecorator
    {
        public OnionDecorator(Vegetable vegy) : base(vegy.Name, vegy.Price, vegy)
        {
        }
    }
}
