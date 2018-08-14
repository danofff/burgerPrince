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
    public class BurgerBuilder
    {
        
        public Burger Burger { get; private set; }
        public void CreateBurger()
        {
            Burger = new Burger();
        }
        public void SetMeat(Meat meat)
        {
            Burger.burgerMeat = meat;
        }
        public void SetVegetables(List<Vegetable> vegy)
        {
            Burger.burgerVegy = vegy;
        }
        public void SetChesse(Cheese cheese)
        {
            Burger.burgerCheese = cheese;
        }
        public void SetBun(Bun bun)
        {
            Burger.burgerBun = bun;
        }
    }
}
