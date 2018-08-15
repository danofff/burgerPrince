using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace burgerPrince.Model.Cheese_
{
    public class Cheese : ICheese
    {
        [Key]
        public int CheeseId { get; set; }
        public string Name { get; private set; }
        public float Price { get; private set; }
        public Cheese(string name, float price)
        {
            Name = name;
            Price = price;
        }
        public ICheese Clone()
        {
            return new Cheese(Name, Price); 
        }
    }
}
