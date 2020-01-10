using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Models.Interfaces
{
    /// <summary>
    /// Represents a single pizza topping
    /// ex. pepperoni, mushrooms
    /// </summary>
    public class PizzaTopping
    {
        public PizzaTopping(string toppingName)
        {
            ToppingName = toppingName;
        }

        [Key]
        public int ToppingId { get; set; }
        public string ToppingName { get; set; }
    }
}
