﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burgerPrince.Model.Meat_
{
    public class Beef : Meat
    {
        public Beef(string name, float price)
        {
            Name = "Beef "+name;
            Price = price;
        }        
    }
}
