using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using burgerPrince.Model.Burger_;

namespace burgerPrince.Model.CashMachine_
{
    public class CashMachine
    {
        private static CashMachine machine;
        private static object locker = new object();
        private CashMachine() { }
        public static CashMachine GetSingleton()
        {
            if (machine == null)
                lock (locker)
                {
                    if (machine == null)
                    {
                        machine = new CashMachine();
                    }
                }
            return machine;
        }
        public float CountCost(Burger burger)
        {
            if (burger.burgerBun != null)
            {
                burger.Cost += burger.burgerBun.Price;
            }
            if (burger.burgerMeat != null)
            {
                burger.Cost += burger.burgerMeat.Price;
            }
            if (burger.burgerVegy != null)
            {
                foreach (var vegy in burger.burgerVegy)
                {
                    burger.Cost += vegy.Price;
                }
            }
            if (burger.burgerCheese != null)
            {
                burger.Cost += burger.burgerCheese.Price;
            }
            return burger.Cost;
        }   
    }
}
