using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using burgerPrince.Model.Meat_;
using burgerPrince.Model.Vegetables;
using burgerPrince.Model.Cheese_;

namespace burgerPrince.Model.Burger_
{
    public class Burger
    {
        public Burger()
        {
            Cost = 0;
        }
        public Bun burgerBun { get; set; }
        public Meat burgerMeat { get; set; }
        public List<Vegetable> burgerVegy { get; set; }
        public Cheese burgerCheese { get; set; }
        public float Cost { get; set; }

    }
}
