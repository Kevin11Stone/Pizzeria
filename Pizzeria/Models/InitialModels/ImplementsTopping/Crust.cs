using Pizzeria.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizzeria.Models.InitialModels.ImplementsTopping
{
    public class Crust : IPizzaTopping
    {
        public string ToppingName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}