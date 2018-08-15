using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace burgerPrince.Model.Vegetables
{
    public abstract class Vegetable
    {
        [Key]
        public int VegyId { get; set; }
        public string Name { get; protected set; }
        public float Price { get; protected set; }
        public Vegetable(string name,float price)
        {
            Name = name;
            Price = price;
        }
    }
}
