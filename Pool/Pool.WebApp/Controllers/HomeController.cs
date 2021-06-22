using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Pool.WebApp.Models;

namespace Pool.WebApp.Controllers
{
    public class HomeController : Controller
    {
        UrlPeticion cadena = new UrlPeticion();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {

            if (HttpContext.Session.GetString("user") == null)
            {
                
                return RedirectToAction("Index", "Login");
            }
            else
            {

                ViewBag.Error= HttpContext.Session.GetString("error");

                ViewBag.User = HttpContext.Session.GetString("user");
                ViewData["user"] = HttpContext.Session.GetString("user");

                string id = HttpContext.Session.GetString("user");
                string url_user = cadena.url_user + "/" + id;
                string url_pool = cadena.url_pool+ "/user/" + id;

                using (var http  = new HttpClient())
                {
                    var res = await http.GetStringAsync(url_user);
                    User user = JsonConvert.DeserializeObject<User>(res);
                    var res_pool = await http.GetStringAsync(url_pool);
                    PoolModel pm = JsonConvert.DeserializeObject<PoolModel>(res_pool);

                    ViewBag.Name = user.Name.ToString();

                    ViewBag.Temp = pm.Temp_current.ToString();
                    ViewBag.Ph = pm.Ph_current.ToString();
                    ViewBag.PoolName = (pm.Name_Pool == null) ? "Sin Nombre para la piscina" : pm.Name_Pool.ToString();
                    ViewBag.Location = (pm.Location == null) ? "Sin Locación para la piscina" : pm.Location.ToString();
                    HttpContext.Session.SetString("pool", pm.Id.ToString());

                    switch (pm.Grados.ToString())
                    {
                        case "c": ViewBag.Grados = "°C";
                            break;
                        case "f": ViewBag.Grados = "°F";
                            break;
                        case "k": ViewBag.Grados = "°K";
                            break;
                    }
                }


                
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
