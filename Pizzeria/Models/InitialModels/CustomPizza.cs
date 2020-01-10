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
            this.CustomPizzaToppings = new List<PizzaTopping>();
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
        public string PizzaSauce { get; set; }
        public string PizzaCrust { get; set; }
        public string PizzaCheese { get; set; }

        /// <summary>
        /// Pizza toppings added to a custom pizza.
        /// </summary>
        public ICollection<PizzaTopping> CustomPizzaToppings { get; set; }


    }
}