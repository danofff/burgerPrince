﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burgerPrince.Model.Burger_
{
    public class Bun

    {
        public string Name { get; private set; }
        public float Price { get; private set; }

        public Bun(string name,float price)
        {
            Name = name;
            Price = price;
        }
    }
}
