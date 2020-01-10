namespace Pizzeria.Migrations
{
    using Pizzeria.Models.InitialModels;
    using Pizzeria.Models.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Pizzeria.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Pizzeria.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.


            var signaturePizzas = new List<SignaturePizza>
            {
                new SignaturePizza
                {
                    ItemName = "The James Brown",
                    ItemPrice = 14.00m,
                    ItemDescription = "Makes you want to dance!",
                    Category = "Pizza",
                    PizzaCheese = "Mozzarella",
                    PizzaSauce = "Traditional",
                    PizzaCrust = "Traditional",
                    Toppings = new List<PizzaTopping>()
                    {
                        new PizzaTopping("Pepporoni"),
                        new PizzaTopping("Sausage"),
                        new PizzaTopping("Ham"),
                        new PizzaTopping("Bacon"),
                        new PizzaTopping("Meatball"),
                    }
                },
                new SignaturePizza
                {
                    ItemName = "The Ray Charles",
                    ItemPrice = 14.50m,
                    ItemDescription = "It'll put Georgia on your mind!",
                    Category = "Pizza",
                    PizzaCheese = "Mozzarella",
                    PizzaSauce = "Garlic Alfredo",
                    PizzaCrust = "Traditional",
                    Toppings = new List<PizzaTopping>()
                    {
                        new PizzaTopping("Green Bell Peppers"),
                        new PizzaTopping("Sausage"),
                        new PizzaTopping("Onion"),
                        new PizzaTopping("Fresh Mushroom"),
                        new PizzaTopping("Black Olive"),
                    }
                },
                new SignaturePizza
                {
                    ItemName = "The Stevie Wonder",
                    ItemPrice = 13.50m,
                    ItemDescription = "It'll make you superstitious!",
                    Category = "Pizza",
                    PizzaCheese = "Vegan Cheese",
                    PizzaSauce = "Traditional",
                    PizzaCrust = "Gluten-free",
                    Toppings = new List<PizzaTopping>()
                    {
                        new PizzaTopping("Vegan Sausage"),
                        new PizzaTopping("Vegan Meatball"),
                        new PizzaTopping("Red Bell Pepper"),
                        new PizzaTopping("Fresh Mushroom"),
                        new PizzaTopping("Black Olive"),
                        new PizzaTopping("Garlic"),
                        new PizzaTopping("Spinach"),
                        new PizzaTopping("Grape Tomato")
                    }
                }


            };

            signaturePizzas.ForEach(s => context.SignaturePizzas.AddOrUpdate(p => p.ItemName, s));
            context.SaveChanges();

        }
    }
}
