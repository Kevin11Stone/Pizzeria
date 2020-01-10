using Pizzeria.Models.InitialModels.ImplementsTopping;
using Pizzeria.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizzeria.Models.InitialModels
{
    public class SignaturePizza : IMenuItem
    {

        public SignaturePizza()
        {
            this.Toppings = new List<IPizzaTopping>();
        }

        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public string Category { get; set; }
        public decimal ItemPrice { get; set; }
        /// <summary>
        /// Returns the name of the item
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{ItemName}";
        }


        // Signature pizza properties
        public Sauce PizzaSauce { get; set; }
        public Crust PizzaCrust { get; set; }
        public Cheese PizzaCheese { get; set; }

        /// <summary>
        /// List of all toppings on the pizza.
        /// </summary>
        public ICollection<IPizzaTopping> Toppings { get; set; }

   
        /// <summary>
        /// Adds topping item to list of toppings in a pizza object.
        /// </summary>
        /// <param name="topping"></param>
        public void AddTopping(IPizzaTopping topping)
        {
            this.Toppings.Add(topping);
        }


    }
}