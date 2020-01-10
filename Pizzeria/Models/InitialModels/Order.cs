using Pizzeria.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizzeria.Models.InitialModels
{
    public class Order
    {

        public Order()
        {
            this.OrderItems = new List<IMenuItem>();
        }

        public int OrderId { get; set; }
        public decimal TotalPrice
        {
            get
            {
                decimal total = 0;
                foreach (IMenuItem item in this.OrderItems)
                {
                    total += item.ItemPrice;
                }
                return total;
            }
            set
            {
                TotalPrice = value;
            }
        }

        /// <summary>
        /// List of items in a given order.
        /// </summary>
        public ICollection<IMenuItem> OrderItems { get; set; }


        /// <summary>
        /// Adds menu item to list of items for an order and 
        /// adds the price of the item to the order's total price.
        /// </summary>
        /// <param name="menuItem">The menu item to add the order</param>
        public void AddItemToOrder(IMenuItem menuItem)
        {
            this.OrderItems.Add(menuItem);
            this.TotalPrice += menuItem.ItemPrice;
        }
    }
}