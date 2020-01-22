using Pizzeria.Models;
using Pizzeria.Models.InitialModels;
using Pizzeria.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Contains helper methods for menu items (CRUD)
/// </summary>
namespace Pizzeria.Database
{

    /// <summary>
    /// Contains helper methods for Menu items (get, add, etc.). 
    /// </summary>
    public class MenuDb
    {


        public static List<Beverage> GetAllBeverages()
        {

            using (var context = new ApplicationDbContext())
            {
                List<Beverage> beverages = context.Beverages.ToList();

                return beverages;
            }

        }




    }
}