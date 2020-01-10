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
                    PizzaCheese = "Mozz",
                    PizzaSauce = "Traditional",
                    PizzaCrust = "Traditional",

                }
            };



        }
    }
}
