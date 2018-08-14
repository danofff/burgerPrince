using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burgerPrince.Model.Vegetables
{
    public class Cucumber : Vegetable
    {
        public Cucumber(string name, float price) : base("Cucumber "+name, price)
        {
        }
    }
}
