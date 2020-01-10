using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizzeria.Models.Interfaces
{
    public interface IMenuItem
    {

        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        /// <summary>
        /// Beverage, pizza, side dish
        /// </summary>
        public string Category { get; set; }
        public decimal ItemPrice { get; set; }

    }
}