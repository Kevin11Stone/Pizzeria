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
            this.Toppings = new List<PizzaTopping>();
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
        public string PizzaSauce { get; set; }
        public string PizzaCrust { get; set; }
        public string PizzaCheese { get; set; }

        /// <summary>
        /// List of all toppings on the signature pizza.
        /// </summary>
        public ICollection<PizzaTopping> Toppings { get; set; }

   
        /// <summary>
        /// Adds topping item to list of toppings in a pizza object.
        /// </summary>
        /// <param name="topping"></param>
        public void AddTopping(PizzaTopping topping)
        {
            this.Toppings.Add(topping);
        }


    }
}