using Pizzeria.Models;
using Pizzeria.Models.InitialModels;
using Pizzeria.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Pizzeria.Database
{
    /// <summary>
    /// Helper class for menu items
    /// </summary>
    public static class MenuDb
    {

        /// <summary>
        /// Returns list of signature pizzas ordered by name
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static List<SignaturePizza> GetAllSignaturePizzas(ApplicationDbContext context)
        {
            List<SignaturePizza> signaturePizzas = context.SignaturePizzas.OrderBy(p => p.ItemName).ToList();

            return signaturePizzas;
        }
       

    }
}