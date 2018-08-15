using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burgerPrince.Model.Meat_
{
    public abstract class Meat
    {
        [Key]
        public int MeatId { get; set; }
        public float Price { get; set; }
        public string Name { get; set; }      
    }
}
