using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pool.WebApp.Controllers
{
    public class TableController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("user") == null)
            {

                return RedirectToAction("Index", "Login");
            }
            else
            {
                ViewBag.User = HttpContext.Session.GetString("user");
                ViewData["user"] = HttpContext.Session.GetString("user");
                return View();
            }
        }





        public ActionResult Salir()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Login");
        }
    }
}
