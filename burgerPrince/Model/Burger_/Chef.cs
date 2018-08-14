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
    public class Chef
    {
        public Burger Prepare(BurgerBuilder burgerBuilder, Bun bun, Meat meat, List<Vegetable> vegy,Cheese cheese)
        {
            burgerBuilder.CreateBurger();
            burgerBuilder.SetBun(bun);
            burgerBuilder.SetMeat(meat);
            burgerBuilder.SetVegetables(vegy);
            burgerBuilder.SetChesse(cheese);

            return burgerBuilder.Burger;
        }
    }
}
