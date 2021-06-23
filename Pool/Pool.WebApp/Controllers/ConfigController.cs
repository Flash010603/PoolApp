using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pool.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Pool.WebApp.Controllers
{
    public class ConfigController : Controller
    {
        UrlPeticion cadena = new UrlPeticion();
        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetString("user") == null)
            {

                return RedirectToAction("Index", "Login");
            }
            else
            {
                ViewBag.User = HttpContext.Session.GetString("user");
                ViewData["user"] = HttpContext.Session.GetString("user");

                if (HttpContext.Session.GetString("pool") == null)
                {
                    ViewBag.ExistsData = false;
                }
                else
                {

                    string url_pool = cadena.url_pool + "/" + HttpContext.Session.GetString("pool");

                    using (var http = new HttpClient())
                    {

                        var res_pool = await http.GetStringAsync(url_pool);
                        PoolModel pm = JsonConvert.DeserializeObject<PoolModel>(res_pool);

                        ViewBag.ExistsData = true;
                        ViewBag.Temp_min = pm.Temp_min.ToString();
                        ViewBag.Temp_max = pm.Temp_max.ToString();

                        ViewBag.Ph_min = pm.Ph_min.ToString();
                        ViewBag.Ph_max = pm.Ph_max.ToString();

                        ViewBag.PoolName = (pm.Name_Pool == null) ? "" : pm.Name_Pool.ToString();
                        ViewBag.Location = (pm.Location == null) ? "" : pm.Location.ToString();


                        switch (pm.Grados.ToString())
                        {
                            case "c":
                                ViewBag.Grados = "°C";
                                break;
                            case "f":
                                ViewBag.Grados = "°F";
                                break;
                            case "k":
                                ViewBag.Grados = "°K";
                                break;
                        }
                    }

                }

                    return View();
            }
        }

        public async Task<IActionResult> Guardar( PoolModel cd )
        {
   
            var client = new HttpClient();
            string url = cadena.url_pool;

            PoolModel data = new PoolModel();

            HttpContext.Session.GetString("pool");
            data.Grados = (cd.Grados == "") ? "c" : cd.Grados;
            data.Location = (cd.Location == "") ? "Sin locación agregada" : cd.Location;
            data.Name_Pool = (cd.Name_Pool == "") ? "Sin Nombre para la piscina" : cd.Name_Pool;
            data.Ph_max = cd.Ph_max;
            data.Ph_min = cd.Ph_min;
            data.Temp_max = cd.Temp_max;
            data.Temp_min = cd.Temp_min;
            data.Id = HttpContext.Session.GetString("pool").ToString();
            data.IdUser= HttpContext.Session.GetString("user").ToString();

            var data_pool = JsonConvert.SerializeObject(data);
            HttpContent content = new StringContent(data_pool, System.Text.Encoding.UTF8, "application/json");

            var response = await client.PutAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                PoolModel data_res = JsonConvert.DeserializeObject<PoolModel>(result);


                if (data_res == null)
                {
                    HttpContext.Session.SetString("error", "1");
                }
                else
                {
                    HttpContext.Session.SetString("error", "0");
                }
            }

            return RedirectToAction("Index", "Home");
        }

        public ActionResult Salir()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Login");
        }

    }
}
