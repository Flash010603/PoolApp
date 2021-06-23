using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pool.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pool.WebApp.Controllers
{
    public class TableController : Controller
    {
        UrlPeticion cadena = new UrlPeticion();
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

                ViewBag.UrlTabla = cadena.url_table+"/"+ HttpContext.Session.GetString("user");
                /*ViewBag.PoolID = HttpContext.Session.GetString("pool");*/



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
