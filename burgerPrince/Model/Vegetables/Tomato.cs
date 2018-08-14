using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burgerPrince.Model.Vegetables
{
    public class Tomato : Vegetable
    {
        public Tomato(string name, float price) : base("Tomato "+name, price)
        {
        }
    }
}
