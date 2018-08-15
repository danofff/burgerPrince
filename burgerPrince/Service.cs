using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using burgerPrince.Model;
using burgerPrince.View;
using burgerPrince.Model.CashMachine_;
using burgerPrince.Model.Burger_;


namespace burgerPrince
{

    public class Service
    {
        private CashMachine mainMachine;
        public Service()
        {
            mainMachine = CashMachine.GetSingleton();
        }

        public float countOrder(Burger burger)
        {
            return mainMachine.CountCost(burger);
        }

    }
}
