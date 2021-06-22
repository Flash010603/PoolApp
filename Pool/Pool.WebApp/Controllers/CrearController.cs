using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pool.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace Pool.WebApp.Controllers
{
    public class CrearController : Controller
    {
        UrlPeticion cadena = new UrlPeticion();
        public async Task<IActionResult> Index(NewUser nu)
        {
            User data_res = null;
            string url = cadena.url_user;
            bool error = false;

            try
            {
                if (ModelState.IsValid)
                {
                    var client = new HttpClient();
                    NewUser newuser = new NewUser();
                    newuser.Password = nu.Username;
                    newuser.Username = nu.Password;
                    newuser.Email = nu.Email;
                    newuser.Name = nu.Name;

                    var data = JsonConvert.SerializeObject(newuser);
                    HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");

                    var response = await client.PostAsync(url, content);

                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        data_res = JsonConvert.DeserializeObject<User>(result);


                        if (data_res == null)
                        {
                            ViewBag.Error = 1;
                            error = true;
                        }
                        else
                        {

                            HttpContext.Session.SetString("user", data_res.Id.ToString());

                            ViewData["user"] = data_res;
                            ViewBag.Data = data_res;
                            TempData["user"] = data_res.ToString();
                        }

                    }

                }

                if (error)
                {
                    return View();
                }
                else
                {
                    if (data_res == null)
                    {
                        return View();
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            catch (Exception exp)
            {
                return View();
            }
        }
    }
}
