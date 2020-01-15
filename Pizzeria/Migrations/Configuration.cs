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
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Pizzeria.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.


            // create signature pizzas
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


            // create beverage objects
            var beverages = new List<Beverage>
            {

                new Beverage
                {
                    Category = "Soft drink",
                    ItemName = "Fountain drink",
                    ItemDescription = "Carbonated soft drink product from major company",
                    ItemPrice = 1.50m
                },
                new Beverage
                {
                    Category = "Alcohol",
                    ItemName = "Beer",
                    ItemDescription = "Craft beer brewed locally",
                    ItemPrice = 5.50m
                },
                new Beverage
                {
                    Category = "Water",
                    ItemName = "Water",
                    ItemDescription = "Bottled water",
                    ItemPrice = 1.20m
                },
                new Beverage
                {
                    Category = "Sports drink",
                    ItemName = "Sports drink",
                    ItemDescription = "Electrolyte-rich soft drink",
                    ItemPrice = 2.50m
                }
            };

            beverages.ForEach(b => context.Beverages.AddOrUpdate(p => p.ItemName, b));
            context.SaveChanges();


            var sideDishes = new List<SideDish>
            {

                new SideDish
                {
                    ItemName = "Breadsticks",
                    ItemDescription = "Garlic parmesan butter breadsticks",
                    ItemPrice = 6.99m,
                    Category = "Breadsticks",         
                },
                new SideDish
                {
                    ItemName = "Chef Salad",
                    ItemDescription = "Romaine, bacon, red onion, grape tomato, goat cheese, blue cheese dressing",
                    ItemPrice = 4.99m,
                    Category = "Salads",
                },
                new SideDish
                {
                    ItemName = "Classic Chicken Caesar",
                    ItemDescription = "Romaine, all-natural chicken breast, parmesan, crouton, caesar dressing",
                    ItemPrice = 4.99m,
                    Category = "Salads",
                },
                new SideDish
                {
                    ItemName = "Chopped Antipasto",
                    ItemDescription = "Romaine, pepperoni, mozzarella, grape tomato, black olive, banana pepper, red onion, red wine vinegar and olive oil vinagrette",
                    ItemPrice = 4.99m,
                    Category = "Salads",
                },
                new SideDish
                {
                    ItemName = "Bacon & Blu",
                    ItemDescription = "Romaine, bacon, red onion, grape tomato, goat cheese, blue cheese dressing",
                    ItemPrice = 4.99m,
                    Category = "Salads",
                },
                new SideDish
                {
                    ItemName = "Buffalo Chicken Wings",
                    ItemDescription = "12 bone-in hot wings doused with Buffalo sauce",
                    ItemPrice = 7.50m,
                    Category = "Chicken Wings",
                },
                new SideDish
                {
                    ItemName = "BBQ Chicken Wings",
                    ItemDescription = "12 bone-in chicken wings doused with BBQ sauce",
                    ItemPrice = 7.50m,
                    Category = "Chicken Wings",
                }
            };

            sideDishes.ForEach(s => context.SideDishes.AddOrUpdate(n => n.ItemName, s));
            context.SaveChanges();

        }
    }
}
