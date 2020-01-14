using Pizzeria.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pizzeria.Models.InitialModels
{

    /// <summary>
    /// Represents a single order a customer creates.
    /// </summary>
    public class Order
    {

        public Order()
        {
            this.OrderItems = new List<IMenuItem>();
        }

        [Key]
        public int OrderId { get; set; }

        /// <summary>
        /// The total of every menu item's price in the order items list.
        /// </summary>
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
        /// The member to reward points after completion of order.
        /// </summary>
        public ApplicationUser Member { get; set; }


        /// <summary>
        /// Adds menu item to order list and 
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