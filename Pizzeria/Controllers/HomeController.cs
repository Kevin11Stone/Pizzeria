using Microsoft.AspNetCore.Mvc;
using Pizzeria.Models;
using Pizzeria.Models.InitialModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Pizzeria.Controllers
{
    public class HomeController : Controller
    {
 
        public HomeController()
        {

        }


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Order()
        {
            ViewBag.Message = "Your order page.";

            if (User.Identity.IsAuthenticated)
            {
                return View();
            }
            else
            {
                return RedirectToAction("LogIn", "Account");
            }
        }


    }
}