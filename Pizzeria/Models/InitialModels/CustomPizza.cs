using Pizzeria.Models.InitialModels.ImplementsTopping;
using Pizzeria.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizzeria.Models.InitialModels
{

    public class CustomPizza : IMenuItem
    {
        string defaultCustomPizzaName = "Custom Pizza";
        private string _name;

        public CustomPizza()
        {
            this.CustomPizzaToppings = new List<IPizzaTopping>();
        }

        /// <summary>
        /// Always a default name
        /// </summary>
        public string ItemName {
            get => _name;
            set => _name = defaultCustomPizzaName;
        }
        public string ItemDescription { get; set; }
        public string Category { get; set; }
        public decimal ItemPrice { get; set; }

        /// <summary>
        /// Pizza toppings added to a custom pizza.
        /// </summary>
        public ICollection<IPizzaTopping> CustomPizzaToppings { get; set; }



        public Sauce PizzaSauce { get; set; }
        public Crust PizzaCrust { get; set; }
        public Cheese PizzaCheese { get; set; }
    }
}