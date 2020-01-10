using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Models.Interfaces
{
    /// <summary>
    /// Represents a single pizza topping
    /// ex. pepperoni, mushrooms
    /// </summary>
    public interface IPizzaTopping
    {
        public string ToppingName { get; set; }
    }
}
