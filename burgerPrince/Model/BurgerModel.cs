namespace burgerPrince.Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Meat_;
    using Vegetables;
    using Cheese_;
    using Burger_;

    public class BurgerModel : DbContext
    {     
        public BurgerModel()
            : base("name=BurgerModel")
        {
        }

        public virtual DbSet<Meat> BurgersMeat { get; set; }
        public virtual DbSet<Vegetable> BurgersVegy { get; set; }
        public virtual DbSet<Cheese> BurgersCheese { get; set; }
        public virtual DbSet<Bun> BurgersBun { get; set; }

    }
}