﻿using Pizzeria.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Pizzeria.Models.InitialModels
{
    
    /// <summary>
    /// Represents a single beverage item
    /// </summary>
    public class Beverage : IMenuItem
    {
        [Key]
        public int BeverageId { get; set; }
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
    }
}